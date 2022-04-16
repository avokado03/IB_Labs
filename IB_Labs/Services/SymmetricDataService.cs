using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
using SymmetricLib.Algorithms.Interfaces;
using SymmetricLib.Common;
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
            try
            {
                if (Strategies is null)
                    throw new NullReferenceException("Мессадж сделай не забудь");
                foreach (var alg in Strategies)
                {
                    var modes = AlgorithmHelpers.SupportedModes;
                    foreach (var mode in modes)
                    {                           
                        var result = new AlgorithmResultModel();
                        var cm = mode;
                        result.AlgorithmName = alg.AlgorithmName;
                        result.AlgorithmMode = AlgorithmHelpers.GetStringMode(cm);

                        _stopwatch.Start();
                        alg.Encrypt(algorithmParameters, cm);
                        _stopwatch.Stop();
                        result.EncryptionTime = (double) _stopwatch.ElapsedMilliseconds / 1000;

                        _stopwatch.Restart();
                        alg.Decrypt(algorithmParameters, cm);
                        _stopwatch.Stop();
                        result.DecryptionTime = (double) _stopwatch.ElapsedMilliseconds / 1000;

                        results.Add(result);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return results;
        }
    }
}
