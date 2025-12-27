using System;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Models
{
    public class PersonalComputer_KhrapkoDD
    {
        public string Manufacturer { get; set; } = string.Empty;
        public string CpuType { get; set; } = string.Empty;
        public double ClockSpeedGHz { get; set; } // ← старое поле
        public int CpuFrequencyMHz { get; set; } // ← новое поле
        public int RamGb { get; set; }
        public int HddGb { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AgeYears => (int)((DateTime.Now - ReleaseDate).TotalDays / 365.25); // ← вычисляемое поле
    }
}