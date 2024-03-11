using System.IO;
using System.Net;

namespace ISBGroup.Network
{
    public static class Request
    {
        /// <summary>
        /// Ссылка на сервер для проверки лицензий
        /// </summary>
        private readonly static string Enter = "";
        /// <summary>
        /// GET запрос
        /// </summary>
        public static string Get(string method)
        {
            var http = (HttpWebRequest)WebRequest.Create($"{Enter}?{method}");
            http.KeepAlive = false;
            http.UserAgent = "ISBGroup/2.0 appname/appversion";
            return new StreamReader(http.GetResponse().GetResponseStream()).ReadToEnd();    
        }
    }
}
