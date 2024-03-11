using System;
using System.Text;

namespace ISBGroup.Encrypt
{
    public static class Crypter
    {
        /// <summary>
        /// Метод для шифрования текста в формат Base64
        /// </summary>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Метод для декодирования текста из формата Base64
        /// </summary>
        public static string Base64Decode(string text)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
