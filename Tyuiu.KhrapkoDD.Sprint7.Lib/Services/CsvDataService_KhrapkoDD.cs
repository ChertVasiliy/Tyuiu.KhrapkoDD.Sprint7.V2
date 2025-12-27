using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Lib.Services
{
    /// <summary>
    /// Сервис для работы с данными ПК и ритейлеров, хранящимися в CSV-файлах.
    /// Обеспечивает:
    /// - автоматическое создание файлов при первом запуске,
    /// - чтение/запись/удаление записей ПК.
    /// ⚠️ Внимание: формат CSV простой (без кавычек, без экранирования).
    /// Не поддерживает значения, содержащие запятые или символы новой строки.
    /// </summary>
    public class CsvDataService_KhrapkoDD
    {
        // Пути к CSV-файлам
        private readonly string _pcFile;
        private readonly string _retailerFile;

        // Формат даты для записи/чтения
        private const string DateFormat = "yyyy-MM-dd";
        private static readonly CultureInfo CsvCulture = CultureInfo.InvariantCulture;

        /// <summary>
        /// Инициализирует сервис с указанием путей к CSV-файлам.
        /// Если файлы не существуют — создаются с заголовками.
        /// </summary>
        /// <param name="pcFile">Путь к файлу с персональными компьютерами.</param>
        /// <param name="retailerFile">Путь к файлу с ритейлерами.</param>
        public CsvDataService_KhrapkoDD(string pcFile, string retailerFile)
        {
            _pcFile = pcFile ?? throw new ArgumentNullException(nameof(pcFile));
            _retailerFile = retailerFile ?? throw new ArgumentNullException(nameof(retailerFile));

            EnsureFileExists(_pcFile, "Manufacturer,CpuType,ClockSpeedGHz,CpuFrequencyMHz,RamGb,HddGb,ReleaseDate");
            EnsureFileExists(_retailerFile, "Name,Address,Phone,Note");
        }

        /// <summary>
        /// Гарантирует существование CSV-файла.
        /// Если файл не существует — создаёт каталог и записывает заголовок.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="header">Строка заголовка CSV.</param>
        private static void EnsureFileExists(string path, string header)
        {
            if (!File.Exists(path))
            {
                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                File.WriteAllText(path, header + Environment.NewLine);
            }
        }

        /// <summary>
        /// Загружает список ПК из CSV-файла.
        /// Пропускает строки с ошибками (неправильное количество полей, неверный формат даты/чисел).
        /// </summary>
        /// <returns>Список корректно распарсенных ПК.</returns>
        public List<PersonalComputer_KhrapkoDD> LoadPcs()
        {
            if (!File.Exists(_pcFile))
                return new List<PersonalComputer_KhrapkoDD>();

            var lines = File.ReadAllLines(_pcFile);
            var result = new List<PersonalComputer_KhrapkoDD>();

            // Начинаем с 1, пропуская заголовок
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(','); // ⚠️ Простое разделение — не поддерживает запятые внутри значений!

                // Ожидается ровно 7 полей
                if (parts.Length != 7) continue;

                // Безопасный парсинг даты
                if (!DateTime.TryParseExact(parts[6], DateFormat, CsvCulture, DateTimeStyles.None, out var releaseDate))
                    continue;

                // Безопасный парсинг чисел
                if (!double.TryParse(parts[2], NumberStyles.Float, CsvCulture, out var clockSpeedGHz)) continue;
                if (!int.TryParse(parts[3], NumberStyles.Integer, CsvCulture, out var cpuFreqMHz)) continue;
                if (!int.TryParse(parts[4], NumberStyles.Integer, CsvCulture, out var ramGb)) continue;
                if (!int.TryParse(parts[5], NumberStyles.Integer, CsvCulture, out var hddGb)) continue;

                result.Add(new PersonalComputer_KhrapkoDD
                {
                    Manufacturer = parts[0],
                    CpuType = parts[1],
                    ClockSpeedGHz = clockSpeedGHz,
                    CpuFrequencyMHz = cpuFreqMHz,
                    RamGb = ramGb,
                    HddGb = hddGb,
                    ReleaseDate = releaseDate
                });
            }

            return result;
        }

        /// <summary>
        /// Добавляет новый ПК в CSV-файл.
        /// ⚠️ Не проверяет дубликаты.
        /// </summary>
        /// <param name="pc">Объект ПК для сохранения.</param>
        public void AddPc(PersonalComputer_KhrapkoDD pc)
        {
            if (pc == null) throw new ArgumentNullException(nameof(pc));

            // Формируем строку данных
            string line = string.Join(",",
                pc.Manufacturer,
                pc.CpuType,
                pc.ClockSpeedGHz.ToString(CsvCulture),
                pc.CpuFrequencyMHz.ToString(CsvCulture),
                pc.RamGb.ToString(CsvCulture),
                pc.HddGb.ToString(CsvCulture),
                pc.ReleaseDate.ToString(DateFormat, CsvCulture)
            );

            File.AppendAllText(_pcFile, line + Environment.NewLine);
        }

        /// <summary>
        /// Удаляет ПК из CSV-файла.
        /// ⚠️ Текущая реализация ненадёжна: удаляет записи, совпадающие по Manufacturer, CpuType и ReleaseDate.
        /// Если в базе есть два ПК с одинаковыми этими полями — удалятся оба.
        /// В идеале: использовать уникальный ID или полное совпадение всех полей.
        /// </summary>
        /// <param name="pc">ПК, который нужно удалить.</param>
        public void RemovePc(PersonalComputer_KhrapkoDD pc)
        {
            if (pc == null) throw new ArgumentNullException(nameof(pc));

            var allPcs = LoadPcs();

            // ⚠️ Улучшение: сравниваем ВСЕ поля, а не только три
            var filtered = allPcs.Where(x =>
                x.Manufacturer != pc.Manufacturer ||
                x.CpuType != pc.CpuType ||
                Math.Abs(x.ClockSpeedGHz - pc.ClockSpeedGHz) > 1e-6 || // для double
                x.CpuFrequencyMHz != pc.CpuFrequencyMHz ||
                x.RamGb != pc.RamGb ||
                x.HddGb != pc.HddGb ||
                x.ReleaseDate != pc.ReleaseDate
            ).ToList();

            // Перезаписываем файл
            var header = "Manufacturer,CpuType,ClockSpeedGHz,CpuFrequencyMHz,RamGb,HddGb,ReleaseDate";
            var dataLines = filtered.Select(p =>
                string.Join(",",
                    p.Manufacturer,
                    p.CpuType,
                    p.ClockSpeedGHz.ToString(CsvCulture),
                    p.CpuFrequencyMHz.ToString(CsvCulture),
                    p.RamGb.ToString(CsvCulture),
                    p.HddGb.ToString(CsvCulture),
                    p.ReleaseDate.ToString(DateFormat, CsvCulture)
                )
            );

            var allLines = new[] { header }.Concat(dataLines).ToArray();
            File.WriteAllLines(_pcFile, allLines);
        }
    }
}