using ISBGroup.Engine.API;
using ISBGroup.Forms;
using ISBGroup.Tasks.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using VkNet;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
using VkNet.Utils;

namespace ISBGroup.Tasks
{
    public class FlooderTask
    {
        /// <summary>
        /// Коллекция для хранения фото
        /// </summary>
        private List<MediaAttachment> _images;

        /// <summary>
        /// Коллекция для хранения видео
        /// </summary>
        private List<MediaAttachment> _videos;

        private readonly Random _random = new Random();

        /// <summary>
        /// Метод для выбора случайной фразы из файла
        /// </summary>
        /// <param name="fileName">Имя файла с фразами</param>
        /// <returns>Случайная фраза</returns>
        public string RandomPhrase(string fileName)
        {
            var phrases = File.ReadAllLines($"Phrases\\{fileName}").ToList();

            if (phrases.Count == 0)
            {
                LogForm.PushToLog("Отсутствуют фразы для флуда");
                return null;
            }

            return phrases[_random.Next(phrases.Count)];
        }

        /// <summary>
        /// Метод для загрузки фото и видео из текстовых файлов в коллекции
        /// </summary>
        public void UploadTxts()
        {
            _images = new List<MediaAttachment>();
            _videos = new List<MediaAttachment>();

            var imagesPattern = new Regex("photo(-?[0-9]+)_([0-9]+)");
            var videosPattern = new Regex("video(-?[0-9]+)_([0-9]+)");

            // Загрузка фото из файла images.txt
            foreach (var image in File.ReadAllLines("Txts\\Attachments\\images.txt"))
            {
                var match = imagesPattern.Match(image);

                if (match.Success)
                {
                    _images.Add(new Photo
                    {
                        OwnerId = long.Parse(match.Groups[1].Value),
                        Id = long.Parse(match.Groups[2].Value)
                    });
                }
            }

            // Загрузка видео из файла videos.txt
            foreach (var video in File.ReadAllLines("Txts\\Attachments\\videos.txt"))
            {
                var match = videosPattern.Match(video);

                if (match.Success)
                {
                    _videos.Add(new Video()
                    {
                        OwnerId = long.Parse(match.Groups[1].Value),
                        Id = long.Parse(match.Groups[2].Value)
                    });
                }
            }
        }

        /// <summary>
        /// Метод для получения случайного видео
        /// </summary>
        /// <returns>Случайное видео</returns>
        public IReadOnlyCollection<MediaAttachment> RandomVideo()
        {
            if (_videos.Count == 0)
            {
                LogForm.PushToLog("videos.txt пуст");
                return null;
            }

            var randomVideo = _videos[_random.Next(0, _videos.Count)];
            return new List<MediaAttachment> { randomVideo }.AsReadOnly();
        }

        /// <summary>
        /// Метод для получения случайного изображения
        /// </summary>
        /// <returns>Случайное изображение</returns>
        public IReadOnlyCollection<MediaAttachment> RandomImage()
        {
            if (_images.Count == 0)
            {
                LogForm.PushToLog("Нет доступных изображений для флуда");
                return null;
            }

            var randomImage = _images[_random.Next(0, _images.Count)];
            return new List<MediaAttachment> { randomImage }.AsReadOnly();
        }
        /// <summary>
        /// Получение текста сообщения
        /// </summary>
        private string BuildAppeal(LongPoll longPoll, int index)
        {
            var namePlace = longPoll.FlooderTargets[index].NamePlace;
            var name = longPoll.FlooderTargets[index].Name;

            switch (namePlace)
            {
                case "Начало":
                    return name + RandomPhrase(longPoll.PhrasesSource);
                case "Конец":
                    return RandomPhrase(longPoll.PhrasesSource) + name;
                default:
                    return RandomPhrase(longPoll.PhrasesSource);
            }
        }
        /// <summary>
        /// Отправка сообщений в чат
        /// </summary>
        public void SendMessage(LongPoll longPoll, int index)
        {
            UploadTxts();

            var api = longPoll.VkApi;

            var target = longPoll.FlooderTargets;
            var link = target[index].Link;
            var content = target[index].Contains;

            var message = string.Empty;

            var regexChat = new Regex("chat=(.+)").Match(link);
            var regexUser = new Regex("user=(.+)").Match(link);
            var regexWall = new Regex("wall(-?[0-9]+)_([0-9]+)").Match(link);

            if (target.Count == 0)
            {
                LogForm.PushToLog("Отсутствуют цели...");
                return;
            }

            var attachment = new List<MediaAttachment>();

            switch (content)
            {
                case "Текст":
                    message = BuildAppeal(longPoll, index);
                    break;
                case "Рейд (смайлы)":
                    message = Messages.Emoji;
                    attachment = new List<MediaAttachment> { new Wall() { Id = 12, OwnerId = -183805868 } };
                    break;
                case "Текст+фото":
                    message = BuildAppeal(longPoll, index);
                    attachment.AddRange(RandomImage());
                    break;
                case "Текст+видео":
                    message = BuildAppeal(longPoll, index);
                    attachment.AddRange(RandomVideo());
                    break;
            }

            if (longPoll.ModeAutoans)
            {
                var groups = api.Groups.GetById(null, "", null).FirstOrDefault();

                var server = api.Groups.GetLongPollServer((ulong)groups.Id);
                var response =
                    api.Groups.GetBotsLongPollHistory(
                        new BotsLongPollHistoryParams
                        {
                            Server = server.Server,
                            Ts = server.Ts,
                            Key = server.Key,
                            Wait = 5
                        });

                if (regexChat.Success)
                    SendMessageToChat(api, response, regexChat, message, attachment);

                if (regexUser.Success)
                    SendMessageToUser(api, response, regexUser, message, attachment);

                server.Ts = response.Ts;
            }


            if (regexChat.Success)
            {
                api.Messages.Send(new MessagesSendParams
                {
                    Message = message,
                    Attachments = attachment,
                    RandomId = 0,
                    ChatId = long.Parse(regexChat.Groups[1].Value)
                });
            }
            else if (regexUser.Success)
            {
                api.Messages.Send(new MessagesSendParams
                {
                    Message = message,
                    RandomId = 0,
                    UserId = long.Parse(regexUser.Groups[1].Value),
                    Attachments = attachment
                });
            }
            else if (regexWall.Success)
            {
                var wcc = new WallCreateCommentParams
                {
                    OwnerId = long.Parse(regexWall.Groups[1].Value),
                    PostId = long.Parse(regexWall.Groups[2].Value),
                    FromGroup = api.Groups.GetById(null, "", null).FirstOrDefault().Id,
                    Message = message,
                };

                if (link.Contains(":"))
                {
                    var splits = link.Split(':');
                    wcc.ReplyToComment = long.Parse(splits[1]);
                }

                api.Wall.CreateComment(wcc);
            }
            else
                LogForm.PushToLog($"\"{link}\" — неверная ссылка");

            // Добавление +1 к статистике сообщений
            longPoll.StatMessage += 1;
        }
        /// <summary>
        /// Отправка сообщения в чат
        /// </summary>
        private void SendMessageToChat(VkApi api, BotsLongPollHistoryResponse response, Match regexChat, string message, List<MediaAttachment> attachment)
        {
            foreach (var item in response.Updates)
            {
                if (item.GroupId != (ulong)item.Message.FromId)
                {
                    api.Messages.Send(new MessagesSendParams
                    {
                        Message = message,
                        Attachments = attachment,
                        RandomId = 0,
                        ChatId = long.Parse(regexChat.Groups[1].Value)
                    });
                }
            }
        }
        /// <summary>
        /// Отправка сообщения в личные сообщения
        /// </summary>
        private void SendMessageToUser(VkApi api, BotsLongPollHistoryResponse response, Match regexUser, string message, List<MediaAttachment> attachment)
        {
            foreach (var item in response.Updates)
            {
                if (item.GroupId != (ulong)item.Message.FromId)
                {
                    api.Messages.Send(new MessagesSendParams
                    {
                        Message = message,
                        Attachments = attachment,
                        RandomId = 0,
                        UserId = long.Parse(regexUser.Groups[1].Value)
                    });
                }
            }
        }
        /// <summary>
        /// Запуск функции
        /// </summary>
        public async void AsyncWorker(LongPoll longPoll)
        {
            int index = -1;

            while (LongPoll.IsRunning)
            {
                try
                {
                    index = (index + 1) % longPoll.FlooderTargets.Count;

                    if (longPoll.AllTarget)
                        for (int i = 0; i < longPoll.FlooderTargets.Count; i++)
                            SendMessage(longPoll, i);

                    SendMessage(longPoll, index);
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }

                await Task.Run(async () =>
                {
                    await Task.Delay(Convert.ToInt32(longPoll.Delay));
                });
            }
        }
        /// <summary>
        /// Вывод ошибки в логирование
        /// </summary>
        private void HandleException(Exception ex)
        {
            LogForm.PushToLog("[API]: " + ex.Message);
        }
    }
}
