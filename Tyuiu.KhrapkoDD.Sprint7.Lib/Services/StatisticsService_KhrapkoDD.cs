using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Services
{
    /// <summary>
    /// Сервис для вычисления статистических показателей по коллекции персональных компьютеров.
    /// Все методы безопасны к пустым коллекциям и содержат защиту от null-входа.
    /// </summary>
    public class StatisticsService_KhrapkoDD
    {
        /// <summary>
        /// Возвращает количество ПК в указанной коллекции.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>Число элементов в коллекции.</returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public int Count(IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));
            return src.Count();
        }

        /// <summary>
        /// Вычисляет суммарный объём оперативной памяти (RAM) всех ПК в коллекции.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>Сумма значений RamGb (в гигабайтах).</returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public int TotalRam(IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));
            return src.Sum(x => x.RamGb);
        }

        /// <summary>
        /// Вычисляет среднюю частоту процессора (CPU) по всем ПК.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>
        /// Среднее арифметическое значения CpuFrequencyMHz (в мегагерцах).
        /// Возвращает 0, если коллекция пуста.
        /// </returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public double AvgFrequency(IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));
            return src.Any() ? src.Average(x => x.CpuFrequencyMHz) : 0.0;
        }

        /// <summary>
        /// Находит минимальный объём жёсткого диска (HDD) среди всех ПК.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>
        /// Минимальное значение HddGb (в гигабайтах).
        /// Возвращает 0, если коллекция пуста или все значения >= 0.
        /// </returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public int MinHdd(IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));
            return src.Any() ? src.Min(x => x.HddGb) : 0;
        }

        /// <summary>
        /// Находит максимальный объём жёсткого диска (HDD) среди всех ПК.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>
        /// Максимальное значение HddGb (в гигабайтах).
        /// Возвращает 0, если коллекция пуста.
        /// </returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public int MaxHdd(IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));
            return src.Any() ? src.Max(x => x.HddGb) : 0;
        }

        /// <summary>
        /// Группирует ПК по производителю и подсчитывает количество устройств на каждого производителя.
        /// Производители сортируются по убыванию количества ПК.
        /// </summary>
        /// <param name="src">Источник данных (коллекция ПК). Не должен быть null.</param>
        /// <returns>
        /// Список кортежей вида (Manufacturer, Qty), отсортированный по убыванию Qty.
        /// Производители с пустым или null-именем группируются под ключом null.
        /// </returns>
        /// <exception cref="ArgumentNullException">Если <paramref name="src"/> равен null.</exception>
        public List<(string Manufacturer, int Qty)> GroupByManufacturer(
            IEnumerable<PersonalComputer_KhrapkoDD> src)
        {
            if (src == null) throw new ArgumentNullException(nameof(src));

            return src.GroupBy(p => p.Manufacturer) // null-ключи допустимы в GroupBy
                      .Select(g => (Manufacturer: g.Key, Qty: g.Count()))
                      .OrderByDescending(t => t.Qty)
                      .ToList();
        }
    }
}