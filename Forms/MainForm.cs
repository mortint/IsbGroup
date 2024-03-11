using ISBGroup.Configs;
using ISBGroup.Encrypt;
using ISBGroup.Engine.API;
using ISBGroup.Forms.Dialogs;
using ISBGroup.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.RequestParams;

namespace ISBGroup.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект для работы с загруженной группой
        /// </summary>
        private List<LongPoll> Groups;
        /// <summary>
        /// Форма логирования
        /// </summary>
        private LogForm _logForm;
        /// <summary>
        /// Флаг активна ли функция "команды"
        /// </summary>
        private bool WorkChat { get; set; } = false;
        /// <summary>
        /// Объект Timer для работы с таймером
        /// </summary>
        private System.Timers.Timer Timer;
        /// <summary>
        /// Поля для хранения времени таймера
        /// </summary>
        private int Hours, Minutes, Seconds;
        /// <summary>
        /// Поле для хранения Mac-адреса
        /// </summary>
        public string MacAddress { get; set; }
        /// <summary>
        /// Информация о лицензии
        /// </summary>
        public string Information { get; set; }
        /// <summary>
        /// Индекс текущей группы
        /// </summary>
        public int Current { get; set; } = 0;
        /// <summary>
        /// Поле для хранения даты лицензии
        /// </summary>
        public string Date { get; set; }

        public MainForm()
        {
            // Создание объекта stack, содержащий информацию о стеке вызовов.
            var stack = new StackTrace();

            // Получение фрейма из стека вызовов в виде списка и проверяем, существует ли хотя бы один фрейм,
            // удовлетворяющий условиям: фрейм имеет метод и имя метода равно "InvokeMethod".
            if (!stack.GetFrames().ToList().Exists(x => x.HasMethod() && x.GetMethod().Name == "InvokeMethod"))
            {
                Environment.Exit(-1);
            }

            InitializeComponent();
            
            Text += Application.ProductVersion;
            Groups = new List<LongPoll>();
            var toolTip = new ToolTip();

            StartPosition = FormStartPosition.CenterScreen;
            StyleDatagridview();

            Directory.CreateDirectory("Groups");
            Directory.CreateDirectory("Txts");
            Directory.CreateDirectory("Phrases");
            Directory.CreateDirectory("Txts\\Attachments");
            CreateFileIfExists("Txts\\tokens.txt");
            CreateFileIfExists("Txts\\Attachments\\images.txt");
            CreateFileIfExists("Txts\\Attachments\\videos.txt");

            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += OnTimeEvent;
            
            foreach (var item in Directory.GetFiles("Phrases"))
            {
                comboBox_SourcePhrases.Items.Add(Path.GetFileName(item));
            }
        }
        /// <summary>
        /// Восстановление настроек приложение после перезапуска
        /// </summary>
        private void LoadSettings()
        {
            var current = Groups[Current];

            dataGridView_flooderTarget.Rows.Clear();
            textBox_Delay.Text = current.Delay;
            comboBox_SourcePhrases.Text = current.PhrasesSource;
            checkBox_modeAutoans.Checked = current.ModeAutoans;
            checkBox_AllTarget.Checked = current.AllTarget;

            foreach (var item in current.FlooderTargets)
            {
                dataGridView_flooderTarget.Rows.Add(item.Link, item.NamePlace, item.Name, item.Contains);
            }

            new Thread(() => GetInfo(current)).Start();
        }
        /// <summary>
        /// Установка стилей Data Grid
        /// </summary>
        void StyleDatagridview()
        {
            dataGridView_flooderTarget.BorderStyle = BorderStyle.None;
            dataGridView_flooderTarget.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_flooderTarget.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_flooderTarget.DefaultCellStyle.SelectionBackColor = Color.FromArgb(54, 57, 62);
            dataGridView_flooderTarget.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_flooderTarget.BackgroundColor = Color.FromArgb(48, 49, 54);
            dataGridView_flooderTarget.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_flooderTarget.EnableHeadersVisualStyles = false;
            dataGridView_flooderTarget.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_flooderTarget.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 8);
            dataGridView_flooderTarget.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 49, 54);
            dataGridView_flooderTarget.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        /// <summary>
        /// Событие Таймера, которое считает сколько был запущен бот
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Seconds += 1;

                if (Seconds == 60)
                {
                    Seconds = 0;
                    Minutes += 1;

                }

                if (Minutes == 60)
                {
                    Minutes = 0;
                    Hours += 1;
                }

                label_workbot.Text = "Время работы приложения: " + string.Format($"{Hours.ToString().PadLeft(2, '0')}:{Minutes.ToString().PadLeft(2, '0')}:{Seconds.ToString().PadLeft(2, '0')}");
            }));
        }
        private void CreateFileIfExists(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, "");
            }
        }
        /// <summary>
        /// Проверка лицензии и вывод срока лицензии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Shown(object sender, EventArgs e)
        {
            label7.Text = Information;
            if (string.IsNullOrEmpty(Date))
                label_licence.Text += "бессрочно";
            else
                label_licence.Text += Date;

            await LoadGroupsAsync();
        }
        /// <summary>
        /// Авторизация сообществ по токену из tokens.txt
        /// </summary>
        /// <returns></returns>
        public async Task LoadGroupsAsync()
        {
            var tokens = File.ReadAllLines("Txts\\tokens.txt");

            var tasks = tokens.Select(async token =>
            {
                var longPoll = new LongPoll();
                var tokenHash = longPoll.GetTokenHash(token);

                if (!File.Exists($"Groups\\{tokenHash}.json"))
                {
                    longPoll = new LongPoll
                    {
                        Token = token
                    };
                }
                else
                {
                    var json = File.ReadAllText($"Groups\\{tokenHash}.json");
                    longPoll = JsonConvert.DeserializeObject<LongPoll>(json);
                }

                if (longPoll.Connect() == Enums.LongPollEnum.Ok)
                {
                    var groupInfo = await longPoll.VkApi.Groups.GetByIdAsync(null, null, null);
                    var groupName = groupInfo.FirstOrDefault()?.Name;

                    label_TitleGr.Text = "Название сообщества: " + groupName;

                    Groups.Add(longPoll);
                    LogForm.PushToLog(token);
                }
            });

            await Task.WhenAll(tasks);

            button_Next.Visible = Groups.Count > 1;

            if (Groups.Count > 0)
            {
                LoadSettings();
            }
            else
            {
                label_TitleGr.Text = "Сообщества отсутствуют";
            }
        }

        async void GetChat(LongPoll longPoll)
        {
            var api = longPoll.VkApi;

            var groups = api.Groups.GetById(null, "", null).FirstOrDefault();

            while (WorkChat)
            {
                try
                {
                    var server = await api.Groups.GetLongPollServerAsync((ulong)groups.Id);
                    var response =
                        await api.Groups.GetBotsLongPollHistoryAsync(
                            new BotsLongPollHistoryParams
                            {
                                Server = server.Server,
                                Ts = server.Ts,
                                Key = server.Key,
                                Wait = 10
                            });
                    server.Ts = response.Ts;

                    foreach (var update in response.Updates)
                    {
                        if (update.Type != GroupUpdateType.MessageNew)
                            return;

                        // Команда для добавление чата в ДатаГрид
                        if (update.Message.Text.ToLower().Contains("добавить"))
                        {
                            await api.Messages.SendAsync(new MessagesSendParams
                            {
                                Message = "✅ Чат автоматически был добавлен.",
                                RandomId = 0,
                                PeerId = update.Message.PeerId
                            });

                            Invoke(new Action(() =>
                            {
                                try
                                {
                                    dataGridView_flooderTarget.Rows.Add($"chat={update.Message.PeerId - 2000000000}", "Начало", "", "Текст");
                                    button_Save_Click(null, null);
                                }
                                catch 
                                {
                                    LogForm.PushToLog("Ошибка при добавлении чата");
                                }
                            }));
                        }
                        else if (update.Message.Text.ToLower().Contains("стат")) // Команда для вывода статистики сообщений
                        {
                            var message = $"(Текущая сессия) Сообщений отправлено: {longPoll.StatMessage}";
                            var stats = string.Empty;

                            if (!File.Exists(Path.Combine("Configs", "stats.json")))
                            {
                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = "❌ Бот ещё не был запущен. Не удалось получить активные сессии.",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                                return;
                            }

                            var statConfig = GetConfig.StatsConfig.MessageCount;

                            if (statConfig.Count > 0)
                            {
                                for (int count = 0; count < statConfig.Count; count++)
                                {
                                    stats += $"(Сессия #{count + 1}) Сообщений: {Crypter.Base64Decode(statConfig[count])}\n";
                                }

                                message += $"\n\n-----------------\nПрошлые сессии\n{stats}";
                            }

                            await api.Messages.SendAsync(new MessagesSendParams
                            {
                                Message = message,
                                RandomId = 0,
                                PeerId = update.Message.PeerId
                            });
                        }
                        else if (update.Message.Text.ToLower().Contains("цели")) // Команда для вывода целей, указанных в датагрид
                        {
                            var count = $"🎯 Целей указано: {dataGridView_flooderTarget.Rows.Count - 1}\n\n";

                            Invoke(new Action(() =>
                            {
                                try
                                {
                                    for (int i = 0; i < dataGridView_flooderTarget.Rows.Count - 1; i++)
                                    {
                                        count += $"{i + 1}. {dataGridView_flooderTarget.Rows[i].Cells[0].Value}\n";
                                    }
                                }
                                catch
                                {
                                    LogForm.PushToLog("Возникла ошибка при выводе целей");
                                }
                            }));

                            await api.Messages.SendAsync(new MessagesSendParams
                            {
                                Message = count,
                                RandomId = 0,
                                PeerId = update.Message.PeerId
                            });
                        }

                        // Команда для удаление чата из целей (датагрида)
                        if (update.Message.Text.ToLower().Contains("удалить"))
                        {
                            await api.Messages.SendAsync(new MessagesSendParams
                            {
                                Message = "❌ Чат был удален из списка целей.",
                                RandomId = 0,
                                PeerId = update.Message.PeerId
                            });

                            Invoke(new Action(() =>
                            {
                                try
                                {
                                    for (int i = 0; i < dataGridView_flooderTarget.Rows.Count; i++)
                                    {
                                        if (dataGridView_flooderTarget.Rows[i].Cells[0].FormattedValue.ToString()
                                            .Contains($"chat={update.Message.PeerId - 2000000000}"))
                                        {
                                            dataGridView_flooderTarget.Rows.RemoveAt(i);
                                            break;
                                        }
                                    }

                                    button_Save_Click(null, null);
                                }
                                catch 
                                {
                                    LogForm.PushToLog("Возникла ошибка при удалении чата");
                                }
                            }));
                        }
                        else if (update.Message.Text.ToLower().Contains("интервал")) // Команда для устанвоки интервала отправки сообщений
                        {
                            try
                            {
                                var text = update.Message.Text.Split(' ');

                                if (text.Length < 3 || !int.TryParse(text[2], out int interval))
                                {
                                    await api.Messages.SendAsync(new MessagesSendParams
                                    {
                                        Message = "❌ Интервал должен быть числом. Например: интервал 10000",
                                        RandomId = 0,
                                        PeerId = update.Message.PeerId
                                    });
                                    return;
                                }

                                Invoke(new Action(() =>
                                {
                                    textBox_Delay.Text = interval.ToString();
                                    button_Save_Click(null, null);
                                }));

                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = "⌛️ Новый интервал сохранен.",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                            catch (Exception ex)
                            {
                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = $"❌ Возникла ошибка: {ex.Message}",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                        }
                        else if (update.Message.Text.ToLower().Contains("измфразы")) // Команда для изменения источника фраз
                        {
                            try
                            {
                                var text = update.Message.Text.Split(' ');

                                if (text.Length < 3 || !int.TryParse(text[2], out int selectedIndex) || selectedIndex > comboBox_SourcePhrases.Items.Count)
                                {
                                    await api.Messages.SendAsync(new MessagesSendParams
                                    {
                                        Message = "❌ Неверно указан файл с фразами.",
                                        RandomId = 0,
                                        PeerId = update.Message.PeerId
                                    });
                                    return;
                                }

                                Invoke(new Action(() =>
                                {
                                    comboBox_SourcePhrases.SelectedIndex = selectedIndex - 1;
                                    button_Save_Click(null, null);
                                }));

                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = "🗒 Источник фраз изменен.",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                            catch (Exception ex)
                            {
                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = $"❌ Внутренняя ошибка: {ex.Message}",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                        }

                        // Команда для вывода текущего источника фраз
                        if (update.Message.Text.ToLower().Contains("фразы")) 
                        {
                            try
                            {
                                var phrase = string.Empty;

                                Invoke(new Action(() =>
                                {
                                    var count = 1;

                                    foreach (var item in comboBox_SourcePhrases.Items)
                                    {
                                        phrase += $"{count}. {item}\n";
                                        count++;
                                    }
                                }));

                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = phrase,
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                            catch
                            {
                                await api.Messages.SendAsync(new MessagesSendParams
                                {
                                    Message = "❌ Произошла ошибка.",
                                    RandomId = 0,
                                    PeerId = update.Message.PeerId
                                });
                            }
                        }
                        else
                        {
                            // Получить ID чата при любом сообщении или если не была выполнена ни одна команда
                            await api.Messages.SendAsync(new MessagesSendParams
                            {
                                Message = "💬 Номер чата: " + (update.Message.PeerId - 2000000000) + "\n\n⭐️ ISB Group",
                                RandomId = 0,
                                PeerId = update.Message.PeerId
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogForm.PushToLog("[VK API]: " + ex.Message);
                }

                Thread.Sleep(1500);
            }
        }
        /// <summary>
        /// Получение информации о сообществе
        /// </summary>
        /// <param name="longPoll"></param>
        private void GetInfo(LongPoll longPoll)
        {
            var lp = longPoll.VkApi;

            var info = lp.Groups.GetById(null, "", null).FirstOrDefault();

            Invoke(new Action(() => 
            { 
                pictureBox1.ImageLocation = info.Photo100.ToString();
                label_TitleGr.Text = "Название сообщества: " + info.Name;
            }));
        }
        /// <summary>
        /// Сохранение текущих параметров текущей группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Groups.Count == 0)
                {
                    MessageBox.Show("Невозможно сохранить. Загрузите группу в бота.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var current = Groups[Current];
                current.ParseDataGrid(dataGridView_flooderTarget.Rows);
                current.Delay = textBox_Delay.Text;
                current.PhrasesSource = comboBox_SourcePhrases.Text;
                current.ModeAutoans = checkBox_modeAutoans.Checked;
                current.AllTarget = checkBox_AllTarget.Checked;
                current.Save();

                label_countTarget.Text = "Кол-во целей: " + (dataGridView_flooderTarget.Rows.Count - 1);
            }
            catch (Exception ex)
            {
                LogForm.PushToLog(ex.Message);
            }
        }

        private void button_actionLog_Click(object sender, EventArgs e)
        {
            _logForm?.Close();
            _logForm = new LogForm();
            _logForm.Show();
        }
        /// <summary>
        /// Функция включения команд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GetChat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Groups.Count == 0)
                {
                    MessageBox.Show("Невозможно включить команды. Загрузите группу в бота.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var current = Groups[Current];

                WorkChat = !WorkChat; 

                button_GetChat.Text = WorkChat ? "Выкл команды" : "Команды"; 

                if (WorkChat)
                {
                    Task.Run(() => GetChat(current));
                }
            }
            catch (Exception ex)
            {
                LogForm.PushToLog($"[Ошибка запуска]: {ex.Message}");
            }

        }
        /// <summary>
        /// Запуск активных групп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (Groups.Count == 0)
            {
                MessageBox.Show("Невозможно запустить бота. Загрузите группу в бота.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                LongPoll.IsRunning = true;

                // Запуск таймера для счетчика времени работы приложения
                Timer.Start();

                foreach (var group in Groups)
                {
                    group.StatMessage = 0;
                    group.AsyncWorker();
                }

                button_Start.Enabled = false;
                button_Stop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске бота: {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Остановка бота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                var current = Groups[Current];

                var stats = GetConfig.StatsConfig.MessageCount;

                if (stats.Count == 0)
                {
                    stats.Clear();
                }

                // Шифрование статистики сообщений, чтобы вручную пользователь не изменил значение
                stats.Add(Crypter.Base64Encode(Convert.ToString(current.StatMessage)));
                GetConfig.StatsConfig.Save();
            }
            catch (Exception ex)
            {
                LogForm.PushToLog($"Ошибка при обновлении статистики сообщений: {ex.Message}");
            }

            try
            {
                // Остановка таймера и сброс времени работы
                Timer.Stop();
                Seconds = Hours = Minutes = 0;

                LongPoll.IsRunning = false;
                button_Start.Enabled = true;
                button_Stop.Enabled = false;
            }
            catch (Exception ex)
            {
                LogForm.PushToLog("Ошибка при остановке бота: " + ex.Message);
            }
        }

        private void button_autoUpdater_Click(object sender, EventArgs e)
        {
            var form = new UpdaterForm();
            form.Show();
        }
        /// <summary>
        /// Переключение текущей группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (Current < Groups.Count)
                {
                    Current += 1;
                    button_Back.Visible = true;
                }

                if (Current == Groups.Count - 1)
                    button_Next.Visible = false;

                LoadSettings();
            }
            catch (Exception ex)
            {
                LogForm.PushToLog($"[Ошибка при переключении аккаунта]: {ex.Message}");
            }
        }
        /// <summary>
        /// Переключение назад текущей группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Back_Click(object sender, EventArgs e)
        {
            try
            {
                if (Current < Groups.Count)
                {
                    Current -= 1;
                    button_Next.Visible = true;
                }

                if (Current == 0)
                    button_Back.Visible = false;

                LoadSettings();
            }
            catch (Exception ex)
            {
                LogForm.PushToLog($"[Ошибка при переключении аккаунта]: {ex.Message}");
            }
        }

        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }

        private void textBox_Delay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_websiteProject_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk-isb.ru");
        }

        private void button_charity_Click(object sender, EventArgs e)
        {
            var count = new CalculatorForm();
            count.Show();
        }

        private void button_faq_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk-isb.ru");
        }
        /// <summary>
        /// Вывод загруженных групп в другую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    var form = new GroupsAllForm();

                    foreach (var item in Groups)
                    {
                        var api = item.VkApi;
                        var info = api.Groups.GetById(null, "", null).FirstOrDefault();

                        if (info != null)
                        {
                            form.dataGridView_groups.Rows.Add(info.Name, item.Token);
                        }
                    }

                    form.Show();
                }));
            });
        }
        /// <summary>
        /// Настройка Long Poll в группе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_autoSettingsLongPoll_Click(object sender, EventArgs e)
        {
            try
            {
                var current = Groups[Current];

                var set = new SetSettingsGroups
                {
                    LongPoll = current
                };

                await set.AsyncWorker();

                LogForm.PushToLog("Группа настроена для работы");
            }
            catch (Exception ex)
            {
                LogForm.PushToLog($"[Настройка группы]: {ex.Message}");
            }
        }

        private void button_autoTarget_Click(object sender, EventArgs e)
        {
            var form = new AutoTargetForm();
            form.DataGridView = dataGridView_flooderTarget;
            form.Show();
        }
    }
}