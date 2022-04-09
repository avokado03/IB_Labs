using System.Security.Cryptography;

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
        public string FilePath { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Режим работы
        /// </summary>
        public CipherMode Mode { get; set; }
    }
}
