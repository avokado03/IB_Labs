using System;
using System.IO;
using System.Security.Cryptography;

namespace AsymetricLib.Common
{
	/// <summary>
	/// Генератор ключей для алгоритма RSA
	/// </summary>
    public class KeyGenerator
	{
		private readonly string _publicFileName = "\\PublicOnlyKey";
		private readonly string _privateFileName = "\\PublicPrivateKey";

		/// <summary>
		/// Генерирует ключи и записывает их в
		/// XML-файл в выбранную директорию
		/// </summary>
		/// <param name="dirPath">Путь директории</param>
		public void Generate(string dirPath)
		{
			try
			{
				using (var rsa = new RSACryptoServiceProvider())
				{
					var writer = new StreamWriter(GetKeyPath(dirPath, _privateFileName));
					string publicPrivateKeyXML = rsa.ToXmlString(true);
					writer.Write(publicPrivateKeyXML);
					writer.Close();

					writer = new StreamWriter(GetKeyPath(dirPath, _publicFileName));
					string publicOnlyKeyXML = rsa.ToXmlString(false);
					writer.Write(publicOnlyKeyXML);
					writer.Close();
				}
			}
            catch (Exception ex)
            {
				throw ex;
            }
		}

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
