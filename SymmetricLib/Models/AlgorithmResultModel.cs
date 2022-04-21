using System;
using System.ComponentModel;

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
        /// </summary
        [DisplayName("Наименование алгоритма")]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// Режим работы алгоритма
        /// </summary>
        [DisplayName("Режим работы алгоритма")]
        public string AlgorithmMode { get; set; }

        /// <summary>
        /// Время, затраченное на шифрацию, с
        /// </summary>
        [DisplayName("Время, затраченное на шифрацию, с")]
        public double EncryptionTime { get; set; }

        /// <summary>
        /// Время, затраченное на дешифрацию, с
        /// </summary>
        [DisplayName("Время, затраченное на дешифрацию, с")]
        public double DecryptionTime { get; set; }

        /// <summary>
        /// Общее время, затраченное на обработку файла, c
        /// </summary>
        [DisplayName("Общее время, затраченное на обработку файла, c")]
        public double GeneralTime { 
            get { return Math.Round(EncryptionTime + DecryptionTime, 3); } 
        }
    }
}
