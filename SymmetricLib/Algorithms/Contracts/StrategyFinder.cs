using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SymmetricLib.Algorithms.Contracts
{
    /// <summary>
    /// Класс-хелпер для поиска классов-стратегий
    /// </summary>
    public static class StrategyFinder
    {
        /// <summary>
        /// Находит и создает инстансы классов,
        /// наследуемых от абстрактного класса
        /// стратегий алгоритмов
        /// </summary>
        public static List<SymmetricStrategyBase> Find()
        {
            var strategiesInstances =
                Assembly.GetExecutingAssembly()
                // из всех типов в сборке
                .GetTypes()
                // выбираем те, которые могут быть приведены к базовому классу
                .Where(type => typeof(SymmetricStrategyBase).IsAssignableFrom(type))
                .Where(type =>
                !type.IsAbstract &&
                !type.IsGenericType &&
                // и те, которые удается инициализировать
                type.GetConstructor(new Type[0]) != null)
                // создаем инстансы
                .Select(type => (SymmetricStrategyBase)Activator.CreateInstance(type)) 
                .ToList();
            return strategiesInstances;
        }
    }
}
