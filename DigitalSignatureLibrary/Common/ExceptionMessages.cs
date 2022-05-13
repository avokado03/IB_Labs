namespace DigitalSignatureLibrary.Common
{
    /// <summary>
    /// Сообщения исключений для библиотеки ЭЦП
    /// </summary>
    public class ExceptionMessages
    {
        /// <summary>
        /// Сообщение, возникающее, если импорт ключа не удался
        /// </summary>
        public const string INVALID_KEY_IMPORT_EXCEPTION =
            "Ключ не может быть импортирован";

        /// <summary>
        /// Сообщение, возникающее, если значение хэша - NULL
        /// </summary>
        public const string NULL_HASH_EXCEPTION =
            "Значение хэш-функции не было вычислено";
    }
}
