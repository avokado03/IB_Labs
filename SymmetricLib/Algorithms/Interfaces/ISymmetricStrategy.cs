using SymmetricLib.Models;
using System.Security.Cryptography;

namespace SymmetricLib.Algorithms.Interfaces
{
    /// <summary>
    /// Контракт для стратегий алгоритмов
    /// </summary>
    public interface ISymmetricStrategy
    {
        /// <summary>
        /// Наименование алгоритма
        /// </summary>
        string AlgorithmName { get; }

        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="parameters">Параметры для шифрования</param>
        /// <param name="mode">Режим работы алгоритма</param>
        void Encrypt(AlgorithmParametersModel parameters, CipherMode mode);

        /// <summary>
        /// Метод дешифрации
        /// </summary>
        /// <param name="parameters">Параметры для дешифрации</param>
        /// <param name="mode">Режим работы алгоритма</param>
        void Decrypt(AlgorithmParametersModel parameters, CipherMode mode);
    }
}
