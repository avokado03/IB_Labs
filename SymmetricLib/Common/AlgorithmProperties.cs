namespace SymmetricLib.Common
{
    /// <summary>
    /// Константы для работы с алгоритмами шифрования
    /// </summary>
    public class AlgorithmProperties
    {
        #region Размеры ключей

        /// <summary>
        /// Размер ключа шифрования AES
        /// </summary>
        public const int AES_KEY_SIZE = 256;

        /// <summary>
        /// Размер ключа шифрования DES
        /// </summary>
        public const int DES_KEY_SIZE = 64;

        /// <summary>
        /// Размер ключа шифрования TriplrDES
        /// </summary>
        public const int TRIPLE_DES_KEY_SIZE = 192;

        /// <summary>
        /// Размер ключа шифрования RC2
        /// </summary>
        public const int RC2_KEY_SIZE = 40;

        #endregion

        #region Размеры блоков 

        /// <summary>
        /// Размер блока шифрования AES
        /// </summary>
        public const int AES_BLOCK_SIZE = 128;

        /// <summary>
        /// Размер блока шифрования DES
        /// </summary>
        public const int DES_BLOCK_SIZE = 64;

        /// <summary>
        /// Размер блока шифрования TripleDES
        /// </summary>
        public const int TRIPLE_DES_BLOCK_SIZE = 64;

        /// <summary>
        /// Размер блока шифрования RC2
        /// </summary>
        public const int RC2_BLOCK_SIZE = 64;

        #endregion

        /// <summary>
        /// Количество итераций при генерации ключа
        /// </summary>
        public const int KEY_ITERATION_COUNT = 50000;

        /// <summary>
        /// Размер буфера потоков в байтах (1 Мб)
        /// </summary>
        public const int BUFFER_SIZE = 1048576;
    }
}
