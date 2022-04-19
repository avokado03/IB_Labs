using SymmetricLib.Algorithms.Contracts;
using SymmetricLib.Common;
using SymmetricLib.Models;
using System.Security.Cryptography;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма TripleDES
    /// </summary>
    public class TripleDESStrategy : SymmetricStrategyBase
    {
        public TripleDESStrategy()
        {
            AlgorithmName = "TripleDES";
            OutputFileExtension = ".3des";
        }

        /// <inheritdoc />
        protected override SymmetricAlgorithm GetAlgorithm(
            AlgorithmParametersModel parameters, 
            byte[] salt, 
            CipherMode mode)
        {
            TripleDES tripleDES = TripleDES.Create();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            tripleDES.KeySize = AlgorithmProperties.TRIPLE_DES_KEY_SIZE;
            tripleDES.BlockSize = AlgorithmProperties.TRIPLE_DES_BLOCK_SIZE;
            tripleDES.Mode = mode;
            tripleDES.Padding = PaddingMode.Zeros;

            tripleDES.Key = key.GetBytes(tripleDES.KeySize / 8);
            tripleDES.IV = key.GetBytes(tripleDES.BlockSize / 8);

            return tripleDES;
        }
    }
}
