using System.Security.Cryptography;
using SymmetricLib.Models;
using SymmetricLib.Common;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Класс-фабрика, создающий объекты алгоритмов шифрования
    /// с необходимыми параметрами
    /// </summary>
    public static class SymmetricAlgorithmsFactory
    {
        /// <summary>
        /// Возвращает объект класса, представляющий алгоритм
        /// шифрования Rijnadael (AES).
        /// </summary>
        /// <param name="parameters">Параметры алгоритма</param>
        /// <param name="salt">Соль</param>
        /// <returns>Объект <see cref="RijndaelManaged"/></returns>
        public static RijndaelManaged GetRijndael(AlgorithmParametersModel parameters, byte[] salt, CipherMode mode)
        {
            var aes = new RijndaelManaged();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            aes.KeySize = AlgorithmProperties.AES_KEY_SIZE;
            aes.BlockSize = AlgorithmProperties.AES_BLOCK_SIZE;
            aes.Mode = mode;
            aes.Padding = PaddingMode.PKCS7;

            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            return aes;
        }

        public static DES GetDES(AlgorithmParametersModel parameters, byte[] salt, CipherMode mode)
        {
            DES provider = DES.Create();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            provider.KeySize = AlgorithmProperties.DES_KEY_SIZE;
            provider.BlockSize = AlgorithmProperties.DES_BLOCK_SIZE;
            provider.Mode = mode;
            provider.Padding = PaddingMode.PKCS7;

            provider.Key = key.GetBytes(provider.KeySize / 8);
            provider.IV = key.GetBytes(provider.BlockSize / 8);

            return provider;
        }
    }
}
