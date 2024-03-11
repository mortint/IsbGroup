using ISBGroup.Configs.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ISBGroup.Configs
{
    internal class StatsConfig : IConfig
    {
        /// <summary>
        /// Поле для хранение количества сообщений
        /// </summary>
        [JsonProperty("message_count")] public List<string> MessageCount { get; set; } = new List<string>();

        public void Save()
        {
            File.WriteAllText("Configs\\stats.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
