using ISBGroup.Engine.API;
using System.Linq;
using System.Threading.Tasks;

namespace ISBGroup.Tasks
{
    public class SetSettingsGroups
    {
        /// <summary>
        /// Объект LongPoll для работы с API VK
        /// </summary>
        public LongPoll LongPoll { get; set; }

        /// <summary>
        /// Метод для выполнения установки настроек группы VK
        /// </summary>
        private async Task Running()
        {
            var api = LongPoll.VkApi;
            var groupId = (await api.Groups.GetByIdAsync(null, "", null)).FirstOrDefault().Id;

            // Установка настроек Long Poll сервера
            await api.Groups.SetLongPollSettingsAsync(new VkNet.Model.RequestParams.Groups.SetLongPollSettingsParams
            {
                ApiVersion = "5.95",
                MessageNew = true,
                Enabled = true,
                GroupId = (ulong)groupId,
                MessageAllow = true,
                MessageEdit = true,
                MessageDeny = true,
                MessageReply = true,
                MessageTypingState = true
            });

            // Вызов метода groups.setSettings для установки дополнительных настроек
            await api.CallAsync("groups.setSettings", new VkNet.Utils.VkParameters
            {
                { "group_id", groupId },
                { "messages", true },
                { "bots_capabilities", true },
                { "bots_add_to_chat", true }
            });
        }

        /// <summary>
        /// Метод для асинхронного запуска установки настроек группы VK
        /// </summary>
        public async Task AsyncWorker()
        {
            await Task.Run(() => Running());
        }
    }
}
