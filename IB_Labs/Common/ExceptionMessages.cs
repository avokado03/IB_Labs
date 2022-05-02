namespace IB_Labs.Common
{
    /// <summary>
    /// Сообщения исключений для проекта с UI
    /// </summary>
    public class ExceptionMessages
    {
        /// <summary>
        /// Сообщение, возникающее при отсутствии текста в поле пароля
        /// </summary>
        public const string PASSWORD_ERROR_MESSAGE = "Введите пароль!";

        /// <summary>
        /// Сообщение, возникающее, если на форме обнаружены незаполненные поля
        /// </summary>
        public const string EMPTY_FIELDS_ERROR_MESSAGE = "Заполните необходимые для операции поля!";

        /// <summary>
        /// Сообщение, возникающее, если файл или путь не найден
        /// </summary>
        public const string FILE_NOT_FOUND_ERROR_MESSAGE =
            "Файл не найден или путь к нему некорректен";
    }
}
