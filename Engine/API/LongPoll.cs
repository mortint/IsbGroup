using ISBGroup.Enums;
using ISBGroup.Forms;
using ISBGroup.Targets;
using ISBGroup.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace ISBGroup.Engine.API
{
    public class LongPoll
    {
        /// <summary>
        /// Экземпляр класса VKAPI для работы с VK API
        /// </summary>
        [NonSerialized] public VkApi VkApi;
        /// <summary>
        /// Поле для хранения токена
        /// </summary>
        public string Token { get; set; }

        public List<FlooderTarget> FlooderTargets;
        /// <summary>
        /// Поле для хранение интервала отправки сообщений
        /// </summary>
        public string Delay { get; set; }

        /// <summary>
        /// Поле для хранения источника фраз
        /// </summary>
        public string PhrasesSource { get; set; }
        /// <summary>
        /// Флаг для включения автоответчика
        /// </summary>
        public bool ModeAutoans { get; set; }
        /// <summary>
        /// Флаг для отправки сообщений во все чаты
        /// </summary>
        public bool AllTarget { get; set; }
        /// <summary>
        /// Поле для хранение кол-ва сообщений
        /// </summary>
        [NonSerialized] public int StatMessage;
        /// <summary>
        /// Флаг для установки активна ли функция
        /// </summary>
        public static bool IsRunning = false;
        public LongPoll()
        {
            FlooderTargets = new List<FlooderTarget>();
        }
        /// <summary>
        /// Авторизация группы по токену. Подключение к Long Poll
        /// </summary>
        /// <returns></returns>
        public LongPollEnum? Connect()
        {
            VkApi = new VkApi();

            var authParams = new ApiAuthParams
            {
                AccessToken = Token,
                Settings = Settings.All | Settings.Offline
            };

            try
            {
                VkApi.Authorize(authParams);

                if (!string.IsNullOrEmpty(VkApi.Token))
                {
                    LogForm.PushToLog("Успешная авторизация");
                    return LongPollEnum.Ok;
                }

                LogForm.PushToLog("Токен неверный");
                return LongPollEnum.Invalid;
            }
            catch (Exception ex)
            {
                LogForm.PushToLog("[VK API]: " + ex.Message);
            }

            return LongPollEnum.Other;
        }

        /// <summary>
        /// Парсинг данных из DataGridView
        /// </summary>
        public void ParseDataGrid(DataGridViewRowCollection data)
        {
            FlooderTargets.Clear();

            foreach (DataGridViewRow row in data)
            {
                if (row.Cells[0].Value != null)
                {
                    FlooderTargets.Add(new FlooderTarget
                    {
                        Link = (row.Cells[0].Value ?? "").ToString(),
                        NamePlace = (row.Cells[1].Value ?? "").ToString(),
                        Name = (row.Cells[2].Value ?? "").ToString(),
                        Contains = (row.Cells[3].Value ?? "").ToString()
                    });
                }
            }
        }

        /// <summary>
        /// Запуск активных функций
        /// </summary>
        public void AsyncWorker()
        {
            Task.Run(() => new FlooderTask().AsyncWorker(this));
        }

        /// <summary>
        /// Сохранения данных
        /// </summary>
        public void Save()
        {
            var tokenHash = GetTokenHash(Token);
            File.WriteAllText(Path.Combine("Groups", $"{tokenHash}.json"), JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        /// <summary>
        /// Получение хэша токена
        /// </summary>
        public string GetTokenHash(string token)
        {
            using (var sha256Hash = SHA256.Create())
            {
                var hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(token));
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }

    }
}
