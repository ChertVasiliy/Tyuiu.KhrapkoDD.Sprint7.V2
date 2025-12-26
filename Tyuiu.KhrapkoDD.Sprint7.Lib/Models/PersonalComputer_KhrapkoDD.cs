using System;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Models
{
    public class PersonalComputer_KhrapkoDD
    {
        public string Manufacturer { get; set; } = string.Empty;
        public string CpuType { get; set; } = string.Empty;
        public double ClockSpeedGHz { get; set; }  // ← КЛЮЧЕВОЕ СВОЙСТВО, ТОЧНОЕ ИМЯ
        public int RamGb { get; set; }
        public int HddGb { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CpuFrequencyMHz { get; set; }
        public int YearOfManufacture { get; set; }

        // Добавьте это свойство
        public int AgeYears
        {
            get
            {
                return DateTime.Now.Year - YearOfManufacture;
            }
        }

        // ... остальные свойства и методы
    }
}
