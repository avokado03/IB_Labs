namespace SymmetricLib.Models
{
    /// <summary>
    /// Модель, представляющая параметры шифрования
    /// </summary>
    public class AlgorithmParametersModel
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; private set; }

        public AlgorithmParametersModel(string filePath, string password)
        {
            FilePath = filePath;
            Password = password;
        }
    }
}
