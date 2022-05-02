using System;
using System.IO;
using System.Security.Cryptography;

namespace AsymetricLib.Common
{
    /// <summary>
    /// Сервис для работы с файлами
    /// в контексте RSA-шифрования
    /// </summary>
    public class KeyFileService
	{
		/// <summary>
		/// Генерирует ключи и записывает их в
		/// XML-файл в выбранную директорию
		/// </summary>
		/// <param name="dirPath">Путь директории</param>
		public void GenerateRSAKeyFiles(string dirPath)
		{
			try
			{
				using (var rsa = new RSACryptoServiceProvider())
				{
					var writer = new StreamWriter(GetKeyPath(dirPath, RSAFilesParameters.PRIVATE_FILE_NAME));
					string publicPrivateKeyXML = rsa.ToXmlString(true);
					writer.Write(publicPrivateKeyXML);
					writer.Close();

					writer = new StreamWriter(GetKeyPath(dirPath, RSAFilesParameters.PUBLIC_FILE_NAME));
					string publicOnlyKeyXML = rsa.ToXmlString(false);
					writer.Write(publicOnlyKeyXML);
					writer.Close();
				}
			}
			catch (Exception ex)
			{
				if (ex is NotSupportedException)
					throw new Exception(ExceptionMessages.NOT_SUPPORTED_PATH_ERROR_MESSAGE, ex);
				throw ex;
			}
		}

		/// <summary>
		/// Считывает содержимое файла ключа
		/// </summary>
		/// <param name="filePath">Путь к файлу</param>
		/// <returns>Содержимое файла (строка)</returns>
		public string ReadKeyFile(string filePath)
		{
			return File.ReadAllText(filePath);
		}

		/// <summary>
		/// Получение пути дешифрованного файла из пути зашифрованного
		/// </summary>
		public static Func<string, string> GetDecryptedFilePath = (string encryptedFilePath) => 
		{
			if (!encryptedFilePath.EndsWith(RSAFilesParameters.ENRYPTED_FILE_EXTENSION))
				throw new Exception(ExceptionMessages.WRONG_RSA_FILE_FORMAT_ERROR_MESSAGE);
			return encryptedFilePath.Replace(RSAFilesParameters.ENRYPTED_FILE_EXTENSION, string.Empty);
		};

		/// <summary>
		/// Получение пути для зашифрованного файла
		/// </summary>
		public static Func<string, string> GetEncryptedFilePath = (string filePath) =>
		{
			return string.Format(@"{0}{1}", filePath, RSAFilesParameters.ENRYPTED_FILE_EXTENSION);
		};

		/// <summary>
		/// Конструирует путь для файла, содержащего ключ
		/// </summary>
		private Func<string, string, string> GetKeyPath = (string dirPath, string filePath) => 
		{
			var nowDateTime = DateTime.Now.ToString("_dd-mm-yyyy_HH.mm");
			
			return string.Format(@"{0}{1}_{2}.xml", dirPath, filePath, nowDateTime);
		};
	}
}
