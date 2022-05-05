using System;
using System.IO;
using System.Security.Cryptography;

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
        /// Записывает ЭЦП в файл
        /// </summary>
        /// <param name="filePath">Путь к файлу, для которого создается файл с подписью</param>
        public void WriteSignatureToFile(string filePath)
        {
            try
            {
                var signature = Generate(filePath);
                var signaturePath = signatureFilePath(filePath);

                using(var streamWriter = new StreamWriter(signaturePath))
                {
                    streamWriter.Write(signature);
                }
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
        /// <param name="signatureFilePath">Путь к файлу с подписью</param>
        public bool Validate(string filePath, string signatureFilePath)
        {
            byte[] signature;
            CngKey cngKey;
            bool isValid;

            try
            {
                using (var streamReader = new StreamReader(signatureFilePath))
                using (var memoryStream = new MemoryStream())
                {
                    streamReader.BaseStream.CopyTo(memoryStream);
                    signature = memoryStream.ToArray();
                }

                cngKey = CngKey.Import(signature, CngKeyBlobFormat.EccPrivateBlob);

                using(var dsa = new ECDsaCng(cngKey))
                using(var streamReader = new StreamReader(filePath))
                {
                    isValid = dsa.VerifyData(streamReader.BaseStream, signature);
                }

                return isValid;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Создает цифровую подпись
        /// </summary>
        /// <param name="filePath">Путь к файлу, для которого генерируется подпись</param>
        private byte[] Generate(string filePath)
        {
            CngKeyCreationParameters keyCreationParameters = new CngKeyCreationParameters();
            keyCreationParameters.ExportPolicy = CngExportPolicies.AllowExport;
            keyCreationParameters.KeyUsage = CngKeyUsages.Signing;

            CngKey key = CngKey.Create(CngAlgorithm.ECDsaP256, null, keyCreationParameters);
            byte[] signature;

            using (ECDsaCng dsa = new ECDsaCng(key))
            using (var streamReader = new StreamReader(filePath))
            {
                signature = dsa.SignData(streamReader.BaseStream);
            }
            return signature;
        }

        private static string _signatureFileExtension = ".ecdsa";

        private Func<string, string> signatureFilePath = (string filePath) => 
            string.Format("{0}{1}", filePath, _signatureFileExtension);
    }
}
