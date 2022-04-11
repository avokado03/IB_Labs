using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Models;

namespace IB_Labs.Services
{
    /// <summary>
    /// Сервис получения данных для
    /// сравнительного анализа
    /// симметричных алгоритмов шифрования
    /// </summary>
    public class SymmetricDataService
    {
        private readonly Stopwatch _stopwatch;

        /// <summary>
        /// Список стратегий алгоритмов шифрования
        /// </summary>
        public List<ISymmetricStrategy> Strategies { get; private set; }

        public SymmetricDataService()
        {
            _stopwatch = new Stopwatch();
            Strategies = InterfaceFinder.Find();
        }

        /// <summary>
        /// Получение сравнительных данных шифрования
        /// </summary>
        /// <param name="algorithmParameters">Параметры шифрования</param>
        /// <returns>Список моделей с результатами сравнения</returns>
        public List<AlgorithmResultModel> GetAlgorithmResults(AlgorithmParametersModel algorithmParameters)
        {
            var results = new List<AlgorithmResultModel>();


            return results;
        }
    }
}
