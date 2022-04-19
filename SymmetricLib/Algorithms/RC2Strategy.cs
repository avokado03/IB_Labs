using SymmetricLib.Algorithms.Contracts;
using SymmetricLib.Common;
using SymmetricLib.Models;
using System.Security.Cryptography;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма RC2
    /// </summary>
    public class RC2Strategy : SymmetricStrategyBase
    {
        public RC2Strategy()
        {
            AlgorithmName = "RC2";
            OutputFileExtension = ".rc2";
        }

        /// <inheritdoc />
        protected override SymmetricAlgorithm GetAlgorithm(
            AlgorithmParametersModel parameters, 
            byte[] salt, 
            CipherMode mode)
        {
            RC2 rc2 = RC2.Create();

            var key = new Rfc2898DeriveBytes(parameters.Password,
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            rc2.KeySize = AlgorithmProperties.RC2_KEY_SIZE;
            rc2.BlockSize = AlgorithmProperties.RC2_BLOCK_SIZE;
            rc2.Mode = mode;
            rc2.Padding = PaddingMode.Zeros;

            rc2.Key = key.GetBytes(rc2.KeySize / 8);
            rc2.IV = key.GetBytes(rc2.BlockSize / 8);

            return rc2;
        }
    }
}
