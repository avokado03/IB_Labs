using System;
using System.Security.Cryptography;

namespace SymmetricLib.Common
{
    /// <summary>
    /// Класс-хелпер для работы с алгоритмами шифрования
    /// </summary>
    public static class AlgorithmHelpers
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

        #region Расширения зашифрованных файлов

        /// <summary>
        /// Расширение для AES-файлов
        /// </summary>
        public static Func<string, string> AESFileExtension = (string path) => path + ".aes";

        #endregion

        #region Режимы работы алгоритмов

        /// <summary>
        /// Возвращает режимы работы массивом
        /// </summary>
        public static Func<Array> ModesToArray = () => Enum.GetValues(typeof(CipherMode));

        /// <summary>
        /// Возвращает наименование режима работы
        /// </summary>
        public static Func<CipherMode, string> GetStringMode = (CipherMode mode)
            => Enum.GetName(typeof(CipherMode), mode);

        #endregion
    }
}
