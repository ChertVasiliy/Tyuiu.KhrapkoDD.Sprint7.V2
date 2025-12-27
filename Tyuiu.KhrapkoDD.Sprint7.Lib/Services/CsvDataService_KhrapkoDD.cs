using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Services
{
    public class CsvDataService_KhrapkoDD
    {
        private readonly string _pcFile;
        private readonly string _retailerFile;

        public CsvDataService_KhrapkoDD(string pcFile, string retailerFile)
        {
            _pcFile = pcFile;
            _retailerFile = retailerFile;
            EnsureFileExists(_pcFile, "Manufacturer,CpuType,ClockSpeedGHz,CpuFrequencyMHz,RamGb,HddGb,ReleaseDate");
            EnsureFileExists(_retailerFile, "Name,Address,Phone,Note");
        }

        private static void EnsureFileExists(string path, string header)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, header + Environment.NewLine);
            }
        }

        public List<PersonalComputer_KhrapkoDD> LoadPcs()
        {
            if (!File.Exists(_pcFile)) return new List<PersonalComputer_KhrapkoDD>();
            var lines = File.ReadAllLines(_pcFile);
            var result = new List<PersonalComputer_KhrapkoDD>();
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length == 7 && DateTime.TryParse(parts[6], out var dt))
                {
                    result.Add(new PersonalComputer_KhrapkoDD
                    {
                        Manufacturer = parts[0],
                        CpuType = parts[1],
                        ClockSpeedGHz = double.Parse(parts[2]),
                        CpuFrequencyMHz = int.Parse(parts[3]),
                        RamGb = int.Parse(parts[4]),
                        HddGb = int.Parse(parts[5]),
                        ReleaseDate = dt
                    });
                }
            }
            return result;
        }

        public void AddPc(PersonalComputer_KhrapkoDD pc)
        {
            string line = $"{pc.Manufacturer},{pc.CpuType},{pc.ClockSpeedGHz},{pc.CpuFrequencyMHz},{pc.RamGb},{pc.HddGb},{pc.ReleaseDate:yyyy-MM-dd}";
            File.AppendAllText(_pcFile, line + Environment.NewLine);
        }

        public void RemovePc(PersonalComputer_KhrapkoDD pc)
        {
            var all = LoadPcs();
            var filtered = all.Where(x =>
                x.Manufacturer != pc.Manufacturer ||
                x.CpuType != pc.CpuType ||
                x.ReleaseDate != pc.ReleaseDate
            ).ToList();
            var header = "Manufacturer,CpuType,ClockSpeedGHz,CpuFrequencyMHz,RamGb,HddGb,ReleaseDate";
            var lines = new[] { header }.Concat(filtered.Select(p =>
                $"{p.Manufacturer},{p.CpuType},{p.ClockSpeedGHz},{p.CpuFrequencyMHz},{p.RamGb},{p.HddGb},{p.ReleaseDate:yyyy-MM-dd}"
            ));
            File.WriteAllLines(_pcFile, lines);
        }
    }
}