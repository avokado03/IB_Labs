using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Models;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма AES
    /// </summary>
    public class AESStrategy : ISymmetricStrategy
    {
        /// <inheritdoc/>
        public void Decrypt(AlgorithmParametersModel parameters)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Encrypt(AlgorithmParametersModel parameters)
        {
            throw new NotImplementedException();
        }
    }
}
