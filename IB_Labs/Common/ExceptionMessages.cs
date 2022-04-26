namespace IB_Labs.Common
{
    /// <summary>
    /// Сообщения об ошибках
    /// </summary>
    public class ExceptionMessages
    {
        /// <summary>
        /// Сообщение по умолчанию
        /// </summary>
        public const string DEFAULT_ERROR_MESSAGE = "Непредвиденная ошибка";

        /// <summary>
        /// Сообщение, возникающее при отсутствии текста в поле пароля
        /// </summary>
        public const string PASSWORD_ERROR_MESSAGE = "Введите пароль!";

        /// <summary>
        /// Сообщение, возникающее, если не существует стратегий алгоритмов
        /// </summary>
        public const string EMPTY_ALGORITHMS_LIST_ERROR_MESSAGE = 
            "Не обнаружено реализаций алгоритмов шифрования";

        /// <summary>
        /// Сообщение, возникающее, если файл или путь не найден
        /// </summary>
        public const string FILE_NOT_FOUND_ERROR_MESSAGE =
            "Файл не найден или путь к нему некорректен";
        /// <summary>
        /// Сообщение, возникающее, когда формат пути не поддерживается
        /// </summary>
        public const string NOT_SUPPORTED_PATH_ERROR_MESSAGE =
            @"Неверный формат пути файла. Запрещены символы / \ : * ? « < > |";
    }
}
