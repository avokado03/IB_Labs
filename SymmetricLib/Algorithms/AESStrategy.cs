using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Common;
using SymmetricLib.Models;
using System.Security.Cryptography;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма AES
    /// </summary>
    public class AESStrategy : SymmetricStrategyBase
    {
        public AESStrategy()
        {
            AlgorithmName = "AES";
        }

        protected override SymmetricAlgorithm GetAlgorithm(
            AlgorithmParametersModel parameters, 
            byte[] salt, 
            CipherMode mode)
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
    }
}
