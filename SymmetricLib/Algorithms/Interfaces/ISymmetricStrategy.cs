using System.Security.Cryptography;

namespace SymmetricLib.Algorithms.Interfaces
{
    /// <summary>
    /// Контракт для стратегий алгоритмов
    /// </summary>
    interface ISymmetricStrategy
    {
        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="password">Пароль</param>
        /// <param name="cipherMode">Режим работы алгоритма</param>
        void Encrypt(string path, string password, CipherMode cipherMode);

        /// <summary>
        /// Метод дешифрации
        /// </summary>
        /// <param name="path">Путь к зашифрованному файлу</param>
        /// <param name="password">Пароль</param> 
        /// <param name="cipherMode">Режим работы алгоритма</param>
        void Decrypt(string path, string password, CipherMode cipherMode);
    }
}
