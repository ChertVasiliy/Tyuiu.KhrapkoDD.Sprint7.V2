using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Services;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    /// <summary>
    /// Главная форма приложения для управления базой персональных компьютеров.
    /// Обеспечивает отображение, добавление, редактирование, удаление ПК,
    /// поиск, просмотр статистики и визуализацию данных.
    /// </summary>
    public partial class MainForm_KhrapkoDD : Form
    {
        // Сервис для работы с CSV-файлами (PC и ритейлеры)
        private readonly CsvDataService_KhrapkoDD _dataService;

        /// <summary>
        /// Конструктор главной формы.
        /// Инициализирует компоненты, подгружает данные и отображает их в таблице.
        /// </summary>
        public MainForm_KhrapkoDD()
        {
            InitializeComponent();

            // Инициализация сервиса данных с путями к CSV-файлам
            // ⚠️ В реальном приложении лучше использовать Path.Combine и проверку существования файлов
            _dataService = new CsvDataService_KhrapkoDD(@"Data\pcs_KhrapkoDD.csv", @"Data\retailers_KhrapkoDD.csv");

            // Загрузка данных в таблицу
            LoadDataToGrid_KhrapkoDD();
        }

        /// <summary>
        /// Загружает список ПК из CSV и привязывает его к DataGridView через BindingSource.
        /// </summary>
        private void LoadDataToGrid_KhrapkoDD()
        {
            var pcs = _dataService.LoadPcs(); // Загрузка данных
            bindingSourcePCs_KhrapkoDD.DataSource = pcs;
            dataGridViewPCs_KhrapkoDD.DataSource = bindingSourcePCs_KhrapkoDD;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить".
        /// Открывает форму добавления ПК. При успешном результате — сохраняет ПК в CSV и обновляет таблицу.
        /// </summary>
        private void buttonAdd_KhrapkoDD_Click(object sender, EventArgs e)
        {
            using var form = new AddPcForm_KhrapkoDD();
            if (form.ShowDialog() == DialogResult.OK && form.CreatedPc != null)
            {
                _dataService.AddPc(form.CreatedPc);
                LoadDataToGrid_KhrapkoDD(); // Обновление отображения
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Изменить".
        /// Копирует выделенный ПК, передаёт копию в форму редактирования.
        /// При подтверждении — удаляет старую запись и добавляет новую.
        /// </summary>
        private void buttonEdit_KhrapkoDD_Click(object sender, EventArgs e)
        {
            // Проверка: выбрана ли строка и является ли связанный объект экземпляром PersonalComputer_KhrapkoDD
            if (dataGridViewPCs_KhrapkoDD.CurrentRow?.DataBoundItem is PersonalComputer_KhrapkoDD pc)
            {
                // Создаём копию объекта для редактирования (чтобы не менять оригинал до подтверждения)
                var clone = new PersonalComputer_KhrapkoDD
                {
                    Manufacturer = pc.Manufacturer,
                    CpuType = pc.CpuType,
                    ClockSpeedGHz = pc.ClockSpeedGHz,
                    CpuFrequencyMHz = pc.CpuFrequencyMHz,
                    RamGb = pc.RamGb,
                    HddGb = pc.HddGb,
                    ReleaseDate = pc.ReleaseDate
                };

                using var form = new AddPcForm_KhrapkoDD(clone);
                if (form.ShowDialog() == DialogResult.OK && form.CreatedPc != null)
                {
                    // Удаляем старую запись и добавляем новую
                    _dataService.RemovePc(pc);
                    _dataService.AddPc(form.CreatedPc);
                    LoadDataToGrid_KhrapkoDD();
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить".
        /// Запрашивает подтверждение и удаляет выбранный ПК из CSV.
        /// </summary>
        private void buttonDelete_KhrapkoDD_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KhrapkoDD.CurrentRow?.DataBoundItem is PersonalComputer_KhrapkoDD pc)
            {
                var result = MessageBox.Show(
                    "Вы уверены, что хотите удалить этот компьютер?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _dataService.RemovePc(pc);
                    LoadDataToGrid_KhrapkoDD();
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Статистика".
        /// Показывает средний объём RAM и максимальную частоту CPU среди всех ПК.
        /// </summary>
        private void buttonStats_KhrapkoDD_Click(object sender, EventArgs e)
        {
            var pcs = _dataService.LoadPcs();
            if (!pcs.Any())
            {
                MessageBox.Show("Нет данных для анализа.", "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double avgRam = pcs.Average(p => p.RamGb);
            int maxCpuFreq = pcs.Max(p => p.CpuFrequencyMHz);

            MessageBox.Show(
                $"Средний объём RAM: {avgRam:F1} ГБ\nМаксимальная частота CPU: {maxCpuFreq} МГц",
                "Статистика",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Обработчик нажатия кнопки "График".
        /// Строит столбчатую диаграмму: производитель ПК → частота CPU (МГц).
        /// </summary>
        private void buttonChart_KhrapkoDD_Click(object sender, EventArgs e)
        {
            var chart = chart1_KhrapkoDD;
            chart.Series.Clear();

            var pcs = _dataService.LoadPcs();
            if (!pcs.Any())
            {
                MessageBox.Show("Нет данных для построения графика.", "График", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chart.Visible = false;
                return;
            }

            var series = new Series
            {
                Name = "CPU Frequency",
                ChartType = SeriesChartType.Column
            };

            foreach (var pc in pcs)
            {
                // Добавляем точку: X = производитель, Y = частота CPU
                series.Points.AddXY(pc.Manufacturer, pc.CpuFrequencyMHz);
            }

            chart.Series.Add(series);
            chart.Visible = true;
        }

        /// <summary>
        /// Обработчик изменения текста в поле поиска.
        /// Фильтрует ПК по производителю или типу CPU (регистронезависимо).
        /// </summary>
        private void toolStripTextBoxSearch_KhrapkoDD_TextChanged(object sender, EventArgs e)
        {
            string term = toolStripTextBoxSearch_KhrapkoDD.Text.Trim().ToLower();

            var pcs = _dataService.LoadPcs();

            // Безопасная фильтрация: проверяем на null и используем StringComparison
            var filtered = pcs.Where(p =>
                !string.IsNullOrEmpty(p.Manufacturer) && p.Manufacturer.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0 ||
                !string.IsNullOrEmpty(p.CpuType) && p.CpuType.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            bindingSourcePCs_KhrapkoDD.DataSource = filtered;
            bindingSourcePCs_KhrapkoDD.ResetBindings(false);
        }

        /// <summary>
        /// Открывает форму "О программе".
        /// </summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm_KhrapkoDD().ShowDialog();

        /// <summary>
        /// Открывает форму "Руководство пользователя".
        /// </summary>
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e) => new HelpForm_KhrapkoDD().ShowDialog();

        /// <summary>
        /// Закрывает приложение.
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}