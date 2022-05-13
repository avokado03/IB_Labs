using System;
using System.IO;
using System.Security.Cryptography;
using DigitalSignatureLibrary.Common;

namespace DigitalSignatureLibrary
{
    /// <summary>
    /// Сервис для работы с ЭЦП
    /// Выбран алгоритм ECDSA вместо DSA (см. на MSDN)
    /// https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.dsa?view=netframework-4.8
    /// </summary>
    public class SignatureService
    {
        /// <summary>
        /// Записывает ЭЦП и публичный ключ в файлы
        /// </summary>
        /// <param name="filePath">Путь к файлу, для которого создается подпись</param>
        public void WriteSignatureToFile(string filePath)
        {
            try
            {
                var keys = GenerateKeys();
                var hash = GetHash(filePath);
                var signature = GetSignature(keys.privateKey, hash);
                var keyFilePath = FileHelpers.getNewFileExtention(filePath, FileHelpers.ECDSA_KEY_EXTENSION);
                var signaturePath = FileHelpers.getNewFileExtention(filePath, FileHelpers.SIGNATURE_FILE_EXTENSION);

                File.WriteAllBytes(keyFilePath, keys.publicKey);
                File.WriteAllBytes(signaturePath, signature);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Проверяет целостность файла по подписи
        /// </summary>
        /// <param name="filePath">Путь к файлу, который подлежит валидации</param>
        /// <param name="publicKeyPath">Путь к файлу с публичным ключом</param>
        /// <param name="signatureFilePath">Путь к файлу с подписью</param>
        public bool Validate(string filePath, string publicKeyPath, string signatureFilePath)
        {
            byte[] signature, publicKey, hash;
            CngKey cngKey;
            bool isValid;

            try
            {
                signature = FileHelpers.GetByteArrayFromFile(signatureFilePath);
                publicKey = FileHelpers.GetByteArrayFromFile(publicKeyPath);
                cngKey = CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob);
                
                using(var dsa = new ECDsaCng(cngKey))
                {
                    hash = GetHash(filePath);
                    isValid = dsa.VerifyHash(hash, signature);
                }

                return isValid;
            }
            catch (CryptographicException cEx)
            {
                throw new Exception(ExceptionMessages.INVALID_KEY_IMPORT_EXCEPTION, cEx);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Генерация ключей
        /// </summary>
        private ECDsaKeys GenerateKeys()
        {
            CngKeyCreationParameters keyCreationParameters = new CngKeyCreationParameters()
            {
                ExportPolicy = CngExportPolicies.AllowPlaintextExport,
                KeyCreationOptions = CngKeyCreationOptions.OverwriteExistingKey,
                UIPolicy = new CngUIPolicy(CngUIProtectionLevels.ProtectKey),
                KeyUsage = CngKeyUsages.Signing
            };
            CngKey key = CngKey.Create(CngAlgorithm.ECDsaP256, null, keyCreationParameters);

            byte[] privateKey = key.Export(CngKeyBlobFormat.EccPrivateBlob);
            byte[] publicKey = key.Export(CngKeyBlobFormat.EccPublicBlob);

            return new ECDsaKeys { privateKey = privateKey, publicKey = publicKey };
        }

        /// <summary>
        /// Вычисляет хэш данных
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        private byte[] GetHash (string filePath)
        {
            byte[] hash = new byte[256];
            using (SHA256Cng sha = new SHA256Cng())
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                hash = sha.ComputeHash(fileStream);
            }
            return hash;
        }

        /// <summary>
        /// Создает сигнатуру
        /// </summary>
        private byte[] GetSignature(byte[] publicKey, byte[] hash)
        {
            byte[] signature;
            try
            {
                var key = CngKey.Import(publicKey, CngKeyBlobFormat.EccPrivateBlob);
                using (ECDsaCng dsa = new ECDsaCng(key))
                {
                    signature = dsa.SignHash(hash);
                }

                return signature;
            }
            catch (ArgumentNullException aEx)
            {
                throw new Exception(ExceptionMessages.NULL_HASH_EXCEPTION, aEx);
            }
            catch(CryptographicException cEx)
            {
                throw new Exception(ExceptionMessages.INVALID_KEY_IMPORT_EXCEPTION, cEx);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
