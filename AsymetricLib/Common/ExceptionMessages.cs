namespace AsymetricLib.Common
{
    /// <summary>
    /// Сообщения исключений при работе с RSA
    /// </summary>
    public class ExceptionMessages
    {
        /// <summary>
        /// Сообщение, возникающее, если пользователь выбирает некорректный
        /// файл с приватным ключом или файл с публичным ключом для дешифрации
        /// </summary>
        public const string WRONG_RSA_KEY_ERROR_MESSAGE =
            "Ключ некорректен и не содержит элементов, необходимых для дешифрования";

        /// <summary>
        /// Сообщение, возникающее если выбран файл c ключом неверного формата
        /// </summary>
        public const string WRONG_RSA_FILE_FORMAT_ERROR_MESSAGE =
            "Файл имеет неверный формат. Допустимы только .xml файлы";

        /// <summary>
        /// Сообщение, возникающее, когда формат пути не поддерживается
        /// </summary>
        public const string NOT_SUPPORTED_PATH_ERROR_MESSAGE =
            @"Неверный формат пути файла. Запрещены символы / \ : * ? « < > |";

        /// <summary>
        /// Сообщение, возникающее если выбран файл неверного формата
        /// </summary>
        public const string WRONG_FILE_FORMAT_ERROR_MESSAGE =
            "Файл имеет неверный формат";
    }
}
