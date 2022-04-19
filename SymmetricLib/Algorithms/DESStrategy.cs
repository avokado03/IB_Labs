using SymmetricLib.Algorithms.Contracts;
using SymmetricLib.Common;
using SymmetricLib.Models;
using System.Security.Cryptography;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма DES
    /// </summary>
    public class DESStrategy : SymmetricStrategyBase
    {
        public DESStrategy()
        {
            AlgorithmName = "DES";
            OutputFileExtension = ".des";
        }

        /// <inheritdoc />
        protected override SymmetricAlgorithm GetAlgorithm(
            AlgorithmParametersModel parameters, 
            byte[] salt, 
            CipherMode mode)
        {
            DES des = DES.Create();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            des.KeySize = AlgorithmProperties.DES_KEY_SIZE;
            des.BlockSize = AlgorithmProperties.DES_BLOCK_SIZE;
            des.Mode = mode;
            des.Padding = PaddingMode.PKCS7;

            des.Key = key.GetBytes(des.KeySize / 8);
            des.IV = key.GetBytes(des.BlockSize / 8);

            return des;
        }
    }
}
