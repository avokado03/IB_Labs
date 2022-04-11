using SymmetricLib.Models;

namespace SymmetricLib.Algorithms.Interfaces
{
    /// <summary>
    /// Контракт для стратегий алгоритмов
    /// </summary>
    public interface ISymmetricStrategy
    {
        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="parameters">Параметры для шифрования</param>
        void Encrypt(AlgorithmParametersModel parameters);

        /// <summary>
        /// Метод дешифрации
        /// </summary>
        /// <param name="parameters">Параметры для дешифрации</param>
        void Decrypt(AlgorithmParametersModel parameters);
    }
}
