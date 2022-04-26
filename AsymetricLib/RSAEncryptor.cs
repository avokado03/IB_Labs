using System;
using System.Security.Cryptography;
using Common;

namespace AsymetricLib
{
    /// <summary>
    /// Выполняет шифрацию и дешифрацию
    /// алгоритмом RSA
    /// </summary>
    public class RSAEncryptor
    {
        /// <summary>
        /// Выполняет шифрование алгоритмом RSA
        /// </summary>
        /// <param name="data">Битовый массив данных</param>
        /// <param name="publicKey">Публичный ключ</param>
        /// <returns>Зашифрованные данные</returns>
        public byte[] Encrypt(byte[] data, string publicKey)
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
        public byte[] Decrypt(byte[] data, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                if (rsa.PublicOnly)
                    throw new Exception(ExceptionMessages.WRONG_RSA_KEY_ERROR_MESSAGE);
                return rsa.Decrypt(data, true);
            }
        }
    }
}
