using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Путь и расширение для выходных файлов
        /// </summary>
        public static Func<string, string, string> GetOutputFilePathExtension = (string path, string extension) 
            => path + extension;

        #region Режимы работы алгоритмов

        /// <summary>
        /// Возвращает допустимые режимы работы списком
        /// https://github.com/dotnet/corefx/blob/master/src/System.Security.Cryptography.Primitives/src/System/Security/Cryptography/CipherMode.cs#L18
        /// </summary>
        public static List<CipherMode> SupportedModes { 
            get 
            {
                return new List<CipherMode> { CipherMode.CBC, CipherMode.ECB };
            } 
        }

        /// <summary>
        /// Возвращает наименование режима работы
        /// </summary>
        public static Func<CipherMode, string> GetStringMode = (CipherMode mode)
            => Enum.GetName(typeof(CipherMode), mode);

        #endregion
    }
}
