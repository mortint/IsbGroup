using Newtonsoft.Json;
using System.IO;

namespace ISBGroup.Configs
{
    internal static class GetConfig
    {
        /// <summary>
        /// Статическое свойство для доступа к конфигурационному объекту RmeConfig 
        /// </summary>
        public static RmeConfig RmeConfig { get; set; }
        /// <summary>
        /// Статическое свойство для доступа к конфигурационному объекту StatsConfig из любой части приложения
        /// </summary>
        public static StatsConfig StatsConfig { get; set; }

        /// <summary>
        /// Восстановление данных из JSON
        /// </summary>
        public static void LoadConfig()
        {
            try
            {
                RmeConfig = JsonConvert.DeserializeObject<RmeConfig>(File.ReadAllText(Path.Combine("Configs", "login.json")));
            }
            catch
            {
                RmeConfig = new RmeConfig();
            }

            try
            {
                StatsConfig = JsonConvert.DeserializeObject<StatsConfig>(File.ReadAllText(Path.Combine("Configs", "stats.json")));
            }
            catch
            {
                StatsConfig = new StatsConfig();
            }
        }
    }
}
