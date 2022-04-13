using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Common;
using SymmetricLib.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SymmetricLib.Algorithms
{
    /// <summary>
    /// Стратегия для алгоритма AES
    /// </summary>
    public class AESStrategy : ISymmetricStrategy
    {
        public string AlgorithmName => "AES 128 (Rijndael)";

        /// <inheritdoc/>
        public void Encrypt(AlgorithmParametersModel parameters, CipherMode mode)
        {
            var salt = AlgorithmHelpers.GenerateRandomSalt();
            string encryptedFilePath = AlgorithmHelpers.AESFileExtension(parameters.FilePath);

            using (var AESAlgorithm = SymmetricAlgorithmsFactory.GetRijndael(parameters, salt, mode))
            {
                byte[] buffer = new byte[AlgorithmProperties.BUFFER_SIZE];
                int read;

                using (var outputStream = new FileStream(encryptedFilePath, FileMode.Create))
                {
                    using (var inputStream = new FileStream(parameters.FilePath, FileMode.Open))
                    {
                        using (var cryptoStream = new CryptoStream(outputStream,
                            AESAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            try
                            {
                                while ((read = inputStream.Read(buffer, 0, buffer.Length)) > 0)
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
        public void Decrypt(AlgorithmParametersModel parameters, CipherMode mode)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(parameters.Password);
            byte[] salt = new byte[32];
            string encryptedFilePath = AlgorithmHelpers.AESFileExtension(parameters.FilePath);

            using (var inputStream = new FileStream(encryptedFilePath, FileMode.Open))
            {
                inputStream.Write(salt, 0, salt.Length);

                using (var AESAlgorithm = SymmetricAlgorithmsFactory.GetRijndael(parameters, salt, mode))
                {
                    byte[] buffer = new byte[AlgorithmProperties.BUFFER_SIZE];
                    int read;

                    using (var cryptoStream = new CryptoStream(inputStream,
                        AESAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (var outputStream = new FileStream(parameters.FilePath, FileMode.Create))
                        {
                            try
                            {
                                while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    outputStream.Write(buffer, 0, read);
                                }
                            }
                            catch (CryptographicException ex_CryptographicException)
                            {
                                throw ex_CryptographicException;
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
    }
}
