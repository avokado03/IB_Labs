namespace AsymetricLib.Common
{
    /// <summary>
    /// Параметры для файлов ключей RSA
    /// </summary>
    public class RSAFilesParameters
    {
        /// <summary>
        /// Наименование файла с публичным ключом
        /// </summary>
        public const string PUBLIC_FILE_NAME = "\\PublicOnlyKey";

        /// <summary>
        /// Наименование файла с закрытым ключом
        /// </summary>
        public const string PRIVATE_FILE_NAME = "\\PublicPrivateKey";

        /// <summary>
        /// Расширение зашифрованных файлов
        /// </summary>
        public const string ENRYPTED_FILE_EXTENSION = ".rsa";
    }
}
