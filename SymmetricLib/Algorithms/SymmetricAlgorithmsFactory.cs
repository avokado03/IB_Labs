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
        public static RijndaelManaged GetRijndael(AlgorithmParametersModel parameters, byte[] salt)
        {
            var aes = new RijndaelManaged();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            aes.KeySize = AlgorithmProperties.KEY_SIZE;
            aes.BlockSize = AlgorithmProperties.BLOCK_SIZE;
            aes.Mode = parameters.Mode;
            aes.Padding = PaddingMode.PKCS7;

            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            return aes;
        }


    }
}
