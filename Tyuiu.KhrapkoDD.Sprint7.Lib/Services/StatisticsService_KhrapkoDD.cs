using System.Collections.Generic;
using System.Linq;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Model;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Services
{
    public class StatisticsService_KhrapkoDD
    {
        public int Count(IEnumerable<PersonalComputer_KhrapkoDD> src) => src.Count();

        public int TotalRam(IEnumerable<PersonalComputer_KhrapkoDD> src) =>
            src.Sum(x => x.RamGb);

        public double AvgFrequency(IEnumerable<PersonalComputer_KhrapkoDD> src) =>
            src.Any() ? src.Average(x => x.CpuFrequencyMHz) : 0;

        public int MinHdd(IEnumerable<PersonalComputer_KhrapkoDD> src) =>
            src.Any() ? src.Min(x => x.HddGb) : 0;

        public int MaxHdd(IEnumerable<PersonalComputer_KhrapkoDD> src) =>
            src.Any() ? src.Max(x => x.HddGb) : 0;

        // кортежи для построения гистограммы «Кол-во ПК по фирмам»
        public List<(string Manufacturer, int Qty)> GroupByManufacturer(
                IEnumerable<PersonalComputer_KhrapkoDD> src) =>
                src.GroupBy(p => p.Manufacturer)
                   .Select(g => (Manufacturer: g.Key, Qty: g.Count())) // явное имя
                   .OrderByDescending(t => t.Qty)
                   .ToList();
    }
}
