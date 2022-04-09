using System;
using System.IO;
using System.Security.Cryptography;
using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Common;
using SymmetricLib.Models;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма AES
    /// </summary>
    public class AESStrategy : ISymmetricStrategy
    {
        /// <inheritdoc/>
        public void Encrypt(AlgorithmParametersModel parameters)
        {
            var salt = SaltGenerator.GenerateRandomSalt();

            var key = new Rfc2898DeriveBytes(parameters.Password, 
                salt, AlgorithmProperties.KEY_ITERATION_COUNT);

            using(var AESAlgorithm = new RijndaelManaged())
            {
                AESAlgorithm.KeySize = AlgorithmProperties.KEY_SIZE;
                AESAlgorithm.BlockSize = AlgorithmProperties.BLOCK_SIZE;
                AESAlgorithm.Mode = parameters.Mode;
                AESAlgorithm.Padding = PaddingMode.PKCS7;

                AESAlgorithm.Key = key.GetBytes(AESAlgorithm.KeySize / 8);
                AESAlgorithm.IV = key.GetBytes(AESAlgorithm.BlockSize / 8);


                byte[] buffer = new byte[1048576];
                int read;

                using (var outputStream = new FileStream(parameters.FilePath + AlgorithmProperties.AES_FILE_EXTENSION,
                    FileMode.Create)) 
                {
                    using (var inputStream = new FileStream(parameters.FilePath, FileMode.Open))
                    {
                        using (var cryptoStream = new CryptoStream(outputStream, 
                            AESAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            try
                            {                             
                                while((read = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    cryptoStream.Write(buffer, 0, read);
                                }
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    } 
                }
            }
        }

        /// <inheritdoc/>
        public void Decrypt(AlgorithmParametersModel parameters)
        {
            throw new NotImplementedException();
        }
    }
}
