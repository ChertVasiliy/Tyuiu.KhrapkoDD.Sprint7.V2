using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Model;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Services
{
    public class CsvDataService_KhrapkoDD
    {
        private readonly string _pcsPath;
        private readonly string _retailersPath;

        public CsvDataService_KhrapkoDD(string dataFolder)
        {
            _pcsPath = Path.Combine(dataFolder, "pcs_KhrapkoDD.csv");
            _retailersPath = Path.Combine(dataFolder, "retailers_KhrapkoDD.csv");
        }

        public List<PersonalComputer_KhrapkoDD> LoadPcs()
        {
            if (!File.Exists(_pcsPath)) return new List<PersonalComputer_KhrapkoDD>();

            using var reader = new StreamReader(_pcsPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<PersonalComputer_KhrapkoDD>().ToList();
        }

        public void SavePcs(List<PersonalComputer_KhrapkoDD> pcs)
        {
            using var writer = new StreamWriter(_pcsPath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(pcs);
        }

        public List<Retailer_KhrapkoDD> LoadRetailers()
        {
            if (!File.Exists(_retailersPath)) return new List<Retailer_KhrapkoDD>();

            using var reader = new StreamReader(_retailersPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Retailer_KhrapkoDD>().ToList();
        }

        public void SaveRetailers(List<Retailer_KhrapkoDD> rr)
        {
            using var writer = new StreamWriter(_retailersPath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(rr);
        }
    }
}
