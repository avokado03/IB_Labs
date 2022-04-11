using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SymmetricLib.Algorithms.Interfaces
{
    /// <summary>
    /// Класс-хелпер для поиска классов-стратегий
    /// </summary>
    public static class InterfaceFinder
    {
        /// <summary>
        /// Находит и создает инстансы классов,
        /// реализующих интерфейс стратегий алгоритмов
        /// </summary>
        public static List<ISymmetricStrategy> Find()
        {
            var strategiesInstances =
                Assembly.GetExecutingAssembly()
                // из всех типов в сборке
                .GetTypes()
                // выбираем те, которые могут быть приведены к интерфейсу
                .Where(type => typeof(ISymmetricStrategy).IsAssignableFrom(type))
                .Where(type =>
                !type.IsAbstract &&
                !type.IsGenericType &&
                // и те, которые удается инициализировать
                type.GetConstructor(new Type[0]) != null)
                // создаем инстансы
                .Select(type => (ISymmetricStrategy)Activator.CreateInstance(type)) 
                .ToList();
            return strategiesInstances;
        }
    }
}
