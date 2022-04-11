using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SymmetricLib.Common
{
    /// <summary>
    /// Константы для работы с алгоритмами шифрования
    /// </summary>
    public class AlgorithmProperties
    {
        /// <summary>
        /// Размер ключа шифрования
        /// </summary>
        public const int KEY_SIZE = 256;

        /// <summary>
        /// Размер блока шифрования
        /// </summary>
        public const int BLOCK_SIZE = 128;

        /// <summary>
        /// Количество итераций при генерации ключа
        /// </summary>
        public const int KEY_ITERATION_COUNT = 50000;

        /// <summary>
        /// Размер буфера потоков в байтах (1 Мб)
        /// </summary>
        public const int BUFFER_SIZE = 1048576;

        #region Расширения зашифрованных файлов

        /// <summary>
        /// Расширение для AES-файлов
        /// </summary>
        public static Func<string, string> AESFileExtension = (string path) => path + ".aes";

        #endregion

        #region Режимы работы алгоритмов

        //public static Dictionary<string, CipherMode[]> AlgorithmsModes = new Dictionary<string, CipherMode[]>
        //{
        //    {nameof(Rijndael), new[] {CipherMode.ECB, CipherMode.CBC, CipherMode.CFB, CipherMode.OFB } },
        //    {nameof(DES), new[] { CipherMode.ECB, CipherMode.CBC, CipherMode.CFB, CipherMode.OFB } },
        //    {nameof(TripleDES), new[] { CipherMode.ECB, CipherMode.CBC, CipherMode.OFB, CipherMode.OFB } },
        //    {nameof(RC2), new[] { } }
        //};

        #endregion
    }
}
