using ISBGroup.Configs.Interface;
using Newtonsoft.Json;
using System.IO;

namespace ISBGroup.Configs
{
    internal class RmeConfig : IConfig
    {
        /// <summary>
        /// Флаг "запомнить меня"
        /// </summary>
        [JsonProperty("remember_me")] public bool RememberMe { get; set; }
        /// <summary>
        /// Поле для хранения пароля
        /// </summary>
        [JsonProperty("password")] public string Password { get; set; } 
        public void Save() => File.WriteAllText(Path.Combine("Configs", "login.json"), JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}
