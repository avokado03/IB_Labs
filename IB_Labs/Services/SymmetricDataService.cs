using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using SymmetricLib.Algorithms.Contracts;
using SymmetricLib.Common;
using SymmetricLib.Models;
using Common;

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
        public List<SymmetricStrategyBase> Strategies { get; private set; }

        public SymmetricDataService()
        {
            _stopwatch = new Stopwatch();
            Strategies = StrategyFinder.Find();
        }

        /// <summary>
        /// Получение сравнительных данных шифрования
        /// </summary>
        /// <param name="algorithmParameters">Параметры шифрования</param>
        /// <returns>Список моделей с результатами сравнения</returns>
        public async Task<List<AlgorithmResultModel>> GetAlgorithmResults(AlgorithmParametersModel algorithmParameters)
        {
            var results = new List<AlgorithmResultModel>();
            try
            {
                if (Strategies is null)
                    throw new NullReferenceException(ExceptionMessages.EMPTY_ALGORITHMS_LIST_ERROR_MESSAGE);
                foreach (var alg in Strategies)
                {
                    var modes = AlgorithmHelpers.SupportedModes;
                    foreach (var mode in modes)
                    {                           
                        var result = new AlgorithmResultModel();
                        result.AlgorithmName = alg.AlgorithmName;
                        result.AlgorithmMode = AlgorithmHelpers.GetStringMode(mode);

                        _stopwatch.Start();
                        alg.Encrypt(algorithmParameters, mode);
                        _stopwatch.Stop();
                        result.EncryptionTime = RoundToSeconds.Invoke(_stopwatch.ElapsedMilliseconds);

                        _stopwatch.Restart();
                        alg.Decrypt(algorithmParameters, mode);
                        _stopwatch.Stop();
                        result.DecryptionTime = RoundToSeconds.Invoke(_stopwatch.ElapsedMilliseconds);

                        results.Add(result);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return await Task.Run(() => results);
        }

        private Func<long, double> RoundToSeconds = (long ms) =>
        {
            return Math.Round((double)ms / 1000, 3);
        };
    }
}
