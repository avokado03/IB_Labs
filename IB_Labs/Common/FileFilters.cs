namespace IB_Labs.Common
{
    /// <summary>
    /// Фильтры для диалоговых окон
    /// </summary>
    public class FileFilters
    {
        /// <summary>
        /// Все файлы
        /// </summary>
        public const string  ALL =  "";

        /// <summary>
        /// XML-файлы ключей
        /// </summary>
        public const string RSA_KEYS = "XML Files (*.xml)|*.xml";

        /// <summary>
        /// ECDSA-ключи
        /// </summary>
        public const string ECDSA_KEYS = "ECDSA Files (*.ecdsa)|*.ecdsa";

        /// <summary>
        /// Файлы, зашифрованные RSA
        /// </summary>
        public const string RSA_ENCRYPTED_FILES = "RSA Files (*.rsa)|*.rsa";

        /// <summary>
        /// Файлы ЭЦП ECDSA
        /// </summary>
        public const string ECDSA_SIGNATURE = "ECDSA Signature Files (*.sign)|*.sign";
    }
}
