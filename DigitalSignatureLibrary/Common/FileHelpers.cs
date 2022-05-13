using System;
using System.IO;

namespace DigitalSignatureLibrary.Common
{
    /// <summary>
    /// Класс методов для работы с файлами
    /// при создании ЭЦП
    /// </summary>
    public static class FileHelpers
    {
        /// <summary>
        /// Расширение файла с публичным ключом
        /// </summary>
        public const string ECDSA_KEY_EXTENSION = ".ecdsa";

        /// <summary>
        /// Расширение файла с сигнатурой
        /// </summary>
        public const string SIGNATURE_FILE_EXTENSION = ".sign";

        /// <summary>
        /// Получение пути файла с учетом нового расширения
        /// </summary>
        public static Func<string, string, string> getNewFileExtention = (string filePath, string extension) =>
            string.Format("{0}{1}", filePath, extension);

        /// <summary>
        /// Представление файла в виде массива байтов
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        public static byte[] GetByteArrayFromFile(string filePath)
        {
            byte[] result;
            using (var streamReader = new StreamReader(filePath))
            using (var memoryStream = new MemoryStream())
            {
                streamReader.BaseStream.CopyTo(memoryStream);
                result = memoryStream.ToArray();
            }
            return result;
        }
    }
}
