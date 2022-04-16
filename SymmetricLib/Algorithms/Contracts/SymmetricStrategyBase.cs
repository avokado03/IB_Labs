using SymmetricLib.Common;
using SymmetricLib.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SymmetricLib.Algorithms.Contracts
{
    /// <summary>
    /// Контракт для стратегий алгоритмов
    /// </summary>
    public abstract class SymmetricStrategyBase
    {
        /// <summary>
        /// Наименование алгоритма
        /// </summary>
        public string AlgorithmName { get; protected set; }

        public string OutputFileExtension { get; protected set; }

        /// <summary>
        /// Возвращает экземпляр алгоритма шифрования.
        /// </summary>
        /// <param name="parameters">Параметры алгоритма</param>
        /// <param name="salt">Соль</param>
        /// <param name="mode">Режим работы</param>
        /// <returns></returns>
        protected abstract SymmetricAlgorithm GetAlgorithm(
            AlgorithmParametersModel parameters,
            byte[] salt,
            CipherMode mode);

        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="parameters">Параметры для шифрования</param>
        /// <param name="mode">Режим работы алгоритма</param>
        public void Encrypt(AlgorithmParametersModel parameters, CipherMode mode)
        {
            var salt = AlgorithmHelpers.GenerateRandomSalt();
            string encryptedFilePath = AlgorithmHelpers
                .GetOutputFilePathExtension(parameters.FilePath, OutputFileExtension);

            using (SymmetricAlgorithm algorithm = GetAlgorithm(parameters, salt, mode))
            {
                byte[] buffer = new byte[AlgorithmProperties.BUFFER_SIZE];
                int read;

                using (var outputStream = new FileStream(encryptedFilePath, FileMode.Create))
                {
                    outputStream.Write(salt, 0, salt.Length);
                    using (var inputStream = new FileStream(parameters.FilePath, FileMode.Open))
                    {
                        using (var cryptoStream = new CryptoStream(outputStream,
                            algorithm.CreateEncryptor(), CryptoStreamMode.Write))
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

        /// <summary>
        /// Метод дешифрации
        /// </summary>
        /// <param name="parameters">Параметры для дешифрации</param>
        /// <param name="mode">Режим работы алгоритма</param>
        public void Decrypt(AlgorithmParametersModel parameters, CipherMode mode)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(parameters.Password);
            byte[] salt = new byte[32];
            string encryptedFilePath = AlgorithmHelpers
                .GetOutputFilePathExtension(parameters.FilePath, OutputFileExtension);

            using (var inputStream = new FileStream(encryptedFilePath, FileMode.Open))
            {
                inputStream.Read(salt, 0, salt.Length);

                using (var algorithm = GetAlgorithm(parameters, salt, mode))
                {
                    byte[] buffer = new byte[AlgorithmProperties.BUFFER_SIZE];
                    int read;

                    using (var cryptoStream = new CryptoStream(inputStream,
                        algorithm.CreateDecryptor(), CryptoStreamMode.Read))
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
