namespace SymmetricLib.Models
{
    /// <summary>
    /// Модель результата обработки
    /// файла алгоритмом шифрования
    /// </summary>
    public class AlgorithmResultModel
    {
        /// <summary>
        /// Наименование алгоритма
        /// </summary>
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Режим работы алгоритма
        /// </summary>
        public string AlgorithmMode { get; set; }

        /// <summary>
        /// Время, затраченное на шифрацию, с
        /// </summary>
        public double EncryptionTime { get; set; }

        /// <summary>
        /// Время, затраченное на дешифрацию, с
        /// </summary>
        public double DecryptionTime { get; set; }

        /// <summary>
        /// Общее время, затраченное на обработку файла
        /// </summary>
        public double GeneralTime { 
            get { return EncryptionTime + DecryptionTime; } 
        }
    }
}
