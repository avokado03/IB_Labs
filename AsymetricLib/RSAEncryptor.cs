using System;
using System.IO;
using System.Security.Cryptography;
using AsymetricLib.Common;
using Common;

namespace AsymetricLib
{
    /// <summary>
    /// Выполняет шифрацию и дешифрацию
    /// алгоритмом RSA
    /// </summary>
    public class RSAEncryptor
    {
        #region Работа с битовыми массивами
        /// <summary>
        /// Выполняет шифрование алгоритмом RSA
        /// </summary>
        /// <param name="data">Битовый массив данных</param>
        /// <param name="publicKey">Публичный ключ</param>
        /// <returns>Зашифрованные данные</returns>
        private byte[] Encrypt(byte[] data, string publicKey)
        {
            using(var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                return rsa.Encrypt(data, true);
            }
        }

        /// <summary>
        /// Выполняет дешифрацию алгоритмом RSA
        /// </summary>
        /// <param name="data">Массив данных</param>
        /// <param name="privateKey">Закрытый ключ</param>
        /// <returns>Дешифрованные данные</returns>
        private byte[] Decrypt(byte[] data, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                if (rsa.PublicOnly)
                    throw new Exception(ExceptionMessages.WRONG_RSA_KEY_ERROR_MESSAGE);
                return rsa.Decrypt(data, true);
            }
        }
        #endregion

        // Т.к. RSA шифрует только данные не длиннее своего ключа, 
        // воспользуемся дополнительно симметричным AES
        #region Работа с файлами

        /// <summary>
        /// Шифрует файл связкой алгоритмов AES+RSA
        /// </summary>
        /// <param name="inputFilePath">Путь шифруемого файла</param>
        /// <param name="publicKey">Публичный ключ</param>
        public void EncryptFile(string inputFilePath, string publicKey)
        {
            using (var aes = new AesManaged())
            {
                // Генерация рандомных ключа и IV для AES
                var key = new byte[aes.KeySize / 8];
                var iv = new byte[aes.BlockSize / 8];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(key);
                    rng.GetBytes(iv);
                }

                // Шифрование симметричного ключа и IV алгоритмом RSA
                var buf = new byte[key.Length + iv.Length];
                Array.Copy(key, buf, key.Length);
                Array.Copy(iv, 0, buf, key.Length, iv.Length);
                try
                {
                    buf = Encrypt(buf, publicKey);

                    var bufLen = BitConverter.GetBytes(buf.Length);

                    // Шифрование алгоритмом AES и запись в файл вместе с уже зашифрованными ассиметрично ключом и IV
                    var outputFilePath = KeyFileService.GetEncryptedFilePath(inputFilePath);
                    using (var cypherKey = aes.CreateEncryptor(key, iv))
                    using (var inputStream = new FileStream(inputFilePath, FileMode.Open))
                    using (var outputStream = new FileStream(outputFilePath, FileMode.Create))
                    using (var cryptoStream = new CryptoStream(outputStream, cypherKey, CryptoStreamMode.Write))
                    {
                        outputStream.Write(bufLen, 0, bufLen.Length);
                        outputStream.Write(buf, 0, buf.Length);
                        inputStream.CopyTo(cryptoStream);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Дешифрует файл связкой алгоритмов AES+RSA
        /// </summary>
        /// <param name="inputFilePath">Путь дешифруемого файла</param>
        /// <param name="privateKey">Приватный ключ</param>
        public void DecryptFile(string inputFilePath, string privateKey)
        {
            using (var aes = new AesManaged())
            using (var inputStream = new FileStream(inputFilePath, FileMode.Open))
            {
                // Определяем длинну зашифрованного AES-ключа и IV
                var buf = new byte[sizeof(int)];
                inputStream.Read(buf, 0, buf.Length);
                var bufLen = BitConverter.ToInt32(buf, 0);

                // Чтение ключа и IV из файла и их дешифрация с помощью RSA
                buf = new byte[bufLen];
                inputStream.Read(buf, 0, buf.Length);
                try
                {
                    buf = Decrypt(buf, privateKey);

                    var key = new byte[aes.KeySize / 8];
                    var iv = new byte[aes.BlockSize / 8];
                    Array.Copy(buf, key, key.Length);
                    Array.Copy(buf, key.Length, iv, 0, iv.Length);

                    // Дешифруем файл с помощью полученных AES-ключа и IV
                    var outputFilePath = KeyFileService.GetDecryptedFilePath(inputFilePath);
                    using (var cypherKey = aes.CreateDecryptor(key, iv))
                    using (var outputStream = new FileStream(outputFilePath, FileMode.Create))
                    using (var cryptoStream = new CryptoStream(outputStream, cypherKey, CryptoStreamMode.Write))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion
    }
}
