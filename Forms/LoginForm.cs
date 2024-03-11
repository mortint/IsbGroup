using ISBGroup.Configs;
using ISBGroup.Engine.Helpers;
using ISBGroup.Network;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ISBGroup.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Directory.CreateDirectory("Configs");

            try
            {
                Text += Application.ProductVersion;

                label_hwid.Text = $"Ключ лицензии: {GetMACAddress()}";

                // Восстановление данных их конфигурации для продолжения работы
                GetConfig.LoadConfig();

                if (GetConfig.RmeConfig.RememberMe)
                {
                    textBox_password.Text = GetConfig.RmeConfig.Password;
                    checkBox_rememberMe.Checked = GetConfig.RmeConfig.RememberMe;
                }
                else
                    GetConfig.RmeConfig = new RmeConfig();
            }
            catch
            {

            }
        }
        /// <summary>
        /// Получение Mac-адреса ПК
        /// </summary>
        /// <returns></returns>
        private string GetMACAddress()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            var sMacAddress = string.Empty;
            foreach (var adapter in nics)
            {
                if (sMacAddress == string.Empty)
                {
                    var properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            return sMacAddress;
        }

        private void button_copyHwid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetMACAddress());
        }
        /// <summary>
        /// Авторизация в приложении и проверка лицензии
        /// </summary>
        private void Login()
        {
            try
            {
                if (!Internet.CheckConnection())
                {
                    var dialogResult = MessageBox.Show("Подключение к интернету слабое или отсутствует. Продолжить?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult != DialogResult.Yes)
                        return;
                }

                // Запрос к серверу для проверки действующей лицензии
                var response = Request.Get($"mac_address={GetMACAddress()}&password={textBox_password.Text}");
                var json = JsonConvert.DeserializeObject<Responses>(response);

                // Обработка ошибок, который может вернуть сервер
                switch (json.ErrorMsg.ToLower())
                {
                    case var errorMsg when errorMsg.Contains("license"):
                        MessageBox.Show("Ваша лицензия истекла. Обратитесь к администраторам: t.me/novikov_w", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case var errorMsg when errorMsg.Contains("invalid"):
                        MessageBox.Show("Неверный пароль. Исправьте ошибки или обратитесь к администраторам: t.me/novikov_w", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case var errorMsg when errorMsg.Contains("empty"):
                        MessageBox.Show("Укажите пароль от своей учетной записи.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case var errorMsg when errorMsg.Contains("unknown"):
                        MessageBox.Show("Неизвестная ошибка. Обратитесь к администраторам: t.me/novikov_w", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case var responseString when responseString.Contains("success"):
                        var mainForm = Assembly.GetExecutingAssembly().CreateInstance("ISBGroup.Forms.MainForm") as MainForm;
                        mainForm.MacAddress = GetMACAddress();
                        mainForm.Information = json.Information;
                        mainForm.Date = json.Date;
                        mainForm.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Неудачный вход. Повторите попытку или перезагрузите приложение.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Приложение вернуло ошибку\n\nТекст ошибки: {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Enter_Click(object sender, EventArgs e)
        {
            new Thread(() => Invoke(new Action(()=> Login()))) { IsBackground = true}.Start();
        }
        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Enter_Click(null, null);
        }

        private void pictureBox_Hat_MouseDown(object sender, MouseEventArgs e)
        {
            ISBGroup.Events.MouseDown.Handle = Handle;
            ISBGroup.Events.MouseDown.MouseOffset(null, null);
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_tme_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk-isb.ru");
        }
        /// <summary>
        /// Сохранение текущих параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rememberMe.Checked)
            {
                GetConfig.RmeConfig.Password = textBox_password.Text;
                GetConfig.RmeConfig.RememberMe = true;
            }
            else GetConfig.RmeConfig = new RmeConfig();

            GetConfig.RmeConfig.Save();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetConfig.RmeConfig.Password = textBox_password.Text;
                GetConfig.RmeConfig.Save();
            }
            catch { }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (!Directory.Exists("Library"))
            {
                MessageBox.Show($"Отсутствует папка \"Library\". Приложение будет закрыто.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
    /// <summary>
    /// Класс, представляющий ответ сервера в формате JSON.
    /// Используется для десериализации данных из JSON.
    /// </summary>
    internal class Responses
    {
        // Деструктор
        ~Responses() => GC.Collect();

        /// <summary>
        /// Поле, которое указывает есть ли ошибка в JSON
        /// </summary>
        [JsonProperty("error")] public string Error { get; set; }
        /// <summary>
        /// Поле, которое хранит в себе текст ошибки
        /// </summary>
        [JsonProperty("error_msg")] public string ErrorMsg { get; set; }
        /// <summary>
        /// Поле для хранение информации о пользователе на сервер
        /// </summary>
        [JsonProperty("info")] public string Information { get; set; }
        /// <summary>
        /// Поле, которое указывает на успешный ответ сервера
        /// </summary>
        [JsonProperty("response")] public string Response { get; set; }
        /// <summary>
        /// Поле, которое содержит в себе дату лицензии
        /// </summary>
        [JsonProperty("date")] public string Date { get; set; }
    }

}
