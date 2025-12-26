using System;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Model
{
    public class PersonalComputer_KhrapkoDD
    {
        // обязательный публичный конструктор без параметров – для CsvHelper
        public PersonalComputer_KhrapkoDD() { }

        public int Id { get; set; }
        public string Manufacturer { get; set; } = "";
        public string CpuType { get; set; } = "";
        public int CpuFrequencyMHz { get; set; }
        public int RamGb { get; set; }
        public int HddGb { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RetailerId { get; set; }

        // удобное readonly-свойство для статистики
        public int AgeYears =>
            DateTime.Now.Year - ReleaseDate.Year;
    }
}
