using System;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Services;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class MainForm_KhrapkoDD : Form
    {
        private readonly CsvDataService_KhrapkoDD _dataService;
        private readonly ToolTip _toolTip; // ← readonly, инициализируется ТОЛЬКО в конструкторе

        public MainForm_KhrapkoDD()
        {
            InitializeComponent();
            _dataService = new CsvDataService_KhrapkoDD(@"Data\pcs_KhrapkoDD.csv", @"Data\retailers_KhrapkoDD.csv");
            _toolTip = new ToolTip(); // ← ОБЯЗАТЕЛЬНО в конструкторе!
            SetupTooltips_KhrapkoDD();
            LoadDataToGrid_KhrapkoDD();
        }

        private void SetupTooltips_KhrapkoDD()
        {
            _toolTip.SetToolTip(toolStripButtonAdd_KhrapkoDD, "Добавить новый ПК");
            _toolTip.SetToolTip(toolStripButtonEdit_KhrapkoDD, "Изменить выбранную запись");
            _toolTip.SetToolTip(toolStripButtonDelete_KhrapkoDD, "Удалить запись");
            _toolTip.SetToolTip(toolStripButtonStats_KhrapkoDD, "Показать полную статистику");
            _toolTip.SetToolTip(toolStripButtonChart_KhrapkoDD, "Показать гистограмму ОЗУ");
            _toolTip.SetToolTip(toolStripButtonRetailers_KhrapkoDD, "Открыть список фирм-реализаторов");
            _toolTip.SetToolTip(toolStripTextBoxSearch_KhrapkoDD, "Поиск по производителю или CPU");
        }

        private void LoadDataToGrid_KhrapkoDD()
        {
            var pcs = _dataService.LoadPcs();
            bindingSourcePCs_KhrapkoDD.DataSource = pcs;
            toolStripStatusLabelCount_KhrapkoDD.Text = $"Записей: {pcs.Count}";
        }

        // === УПРАВЛЕНИЕ ПК ===
        private void buttonAdd_KhrapkoDD_Click(object sender, EventArgs e)
        {
            using var form = new AddPcForm_KhrapkoDD();
            if (form.ShowDialog() == DialogResult.OK && form.CreatedPc != null)
            {
                _dataService.AddPc(form.CreatedPc);
                LoadDataToGrid_KhrapkoDD();
            }
        }

        private void buttonEdit_KhrapkoDD_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KhrapkoDD.CurrentRow?.DataBoundItem is PersonalComputer_KhrapkoDD pc)
            {
                var clone = new PersonalComputer_KhrapkoDD
                {
                    Manufacturer = pc.Manufacturer,
                    CpuType = pc.CpuType,
                    ClockSpeedGHz = pc.ClockSpeedGHz,
                    RamGb = pc.RamGb,
                    HddGb = pc.HddGb,
                    ReleaseDate = pc.ReleaseDate
                };
                using var form = new AddPcForm_KhrapkoDD(clone);
                if (form.ShowDialog() == DialogResult.OK && form.CreatedPc != null)
                {
                    _dataService.RemovePc(pc);
                    _dataService.AddPc(form.CreatedPc);
                    LoadDataToGrid_KhrapkoDD();
                }
            }
        }

        private void buttonDelete_KhrapkoDD_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KhrapkoDD.CurrentRow?.DataBoundItem is PersonalComputer_KhrapkoDD pc)
            {
                if (MessageBox.Show("Удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dataService.RemovePc(pc);
                    LoadDataToGrid_KhrapkoDD();
                }
            }
        }

        // === ПЕРЕХОД В ДРУГИЕ ФОРМЫ ===
        private void buttonStats_KhrapkoDD_Click(object sender, EventArgs e)
        {
            var pcs = _dataService.LoadPcs();
            if (pcs.Any()) new StatisticsForm_KhrapkoDD(pcs).ShowDialog();
        }

        private void buttonChart_KhrapkoDD_Click(object sender, EventArgs e)
        {
            chart1_KhrapkoDD.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "RAM",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            foreach (var pc in _dataService.LoadPcs())
                series.Points.AddXY(pc.Manufacturer, pc.RamGb);
            chart1_KhrapkoDD.Series.Add(series);
            chart1_KhrapkoDD.Visible = true;
        }

        private void buttonRetailers_KhrapkoDD_Click(object sender, EventArgs e)
        {
            new RetailersForm_KhrapkoDD().ShowDialog();
        }

        // === ПОИСК ===
        private void toolStripTextBoxSearch_KhrapkoDD_TextChanged(object sender, EventArgs e)
        {
            string term = toolStripTextBoxSearch_KhrapkoDD.Text.Trim().ToLower();
            var filtered = _dataService.LoadPcs()
                .Where(p => p.Manufacturer.ToLower().Contains(term) ||
                            p.CpuType.ToLower().Contains(term))
                .ToList();
            bindingSourcePCs_KhrapkoDD.DataSource = filtered;
            bindingSourcePCs_KhrapkoDD.ResetBindings(false);
        }

        // === МЕНЮ ===
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm_KhrapkoDD().ShowDialog();
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e) => new HelpForm_KhrapkoDD().ShowDialog();
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
