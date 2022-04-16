namespace SymmetricLib.Common
{
    /// <summary>
    /// Константы для работы с алгоритмами шифрования
    /// </summary>
    public class AlgorithmProperties
    {
        /// <summary>
        /// Размер ключа шифрования AES
        /// </summary>
        public const int AES_KEY_SIZE = 256;

        /// <summary>
        /// Размер ключа шифрования DES
        /// </summary>
        public const int DES_KEY_SIZE = 64;

        /// <summary>
        /// Размер блока шифрования AES
        /// </summary>
        public const int AES_BLOCK_SIZE = 128;

        /// <summary>
        /// Размер блока шифрования DES
        /// </summary>
        public const int DES_BLOCK_SIZE = 64;



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
