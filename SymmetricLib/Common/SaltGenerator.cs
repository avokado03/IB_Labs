using System.Security.Cryptography;

namespace SymmetricLib.Common
{
    /// <summary>
    /// Класс-генератор для работы с солью
    /// </summary>
    public static class SaltGenerator
    {
        /// <summary>
        /// Создает рандомную "соль" для шифрования файла
        /// https://en.wikipedia.org/wiki/Salt_(cryptography)
        /// </summary>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (var rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Заполняет буфер сгенерированными данными
                    rng.GetBytes(data);
                }
            }

            return data;
        }
    }
}
