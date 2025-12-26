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

        public MainForm_KhrapkoDD()
        {
            InitializeComponent();
            _dataService = new CsvDataService_KhrapkoDD(@"Data\pcs_KhrapkoDD.csv", @"Data\retailers_KhrapkoDD.csv");
            LoadDataToGrid_KhrapkoDD();
        }

        private void LoadDataToGrid_KhrapkoDD()
        {
            var pcs = _dataService.LoadPcs();
            bindingSourcePCs_KhrapkoDD.DataSource = pcs;
            dataGridViewPCs_KhrapkoDD.DataSource = bindingSourcePCs_KhrapkoDD;
        }

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
                if (MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dataService.RemovePc(pc);
                    LoadDataToGrid_KhrapkoDD();
                }
            }
        }

        private void buttonStats_KhrapkoDD_Click(object sender, EventArgs e)
        {
            var pcs = _dataService.LoadPcs();
            if (!pcs.Any()) return;
            double avg = pcs.Average(p => p.RamGb);
            double max = pcs.Max(p => p.ClockSpeedGHz);
            MessageBox.Show($"Среднее RAM: {avg:F1} ГБ\nМакс. частота: {max} ГГц", "Статистика");
        }

        private void buttonChart_KhrapkoDD_Click(object sender, EventArgs e)
        {
            // ЯВНОЕ указание пространства имён — устраняет конфликт
            var chart = this.chart1_KhrapkoDD;
            chart.Series.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "RAM",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            foreach (var pc in _dataService.LoadPcs())
            {
                series.Points.AddXY(pc.Manufacturer, pc.RamGb);
            }

            chart.Series.Add(series);
            chart.Visible = true;
        }

        private void toolStripTextBoxSearch_KhrapkoDD_TextChanged(object sender, EventArgs e)
        {
            string term = toolStripTextBoxSearch_KhrapkoDD.Text.Trim().ToLower();
            var filtered = _dataService.LoadPcs()
                .Where(p => p.Manufacturer.ToLower().Contains(term) || p.CpuType.ToLower().Contains(term))
                .ToList();
            bindingSourcePCs_KhrapkoDD.DataSource = filtered;
            bindingSourcePCs_KhrapkoDD.ResetBindings(false);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm_KhrapkoDD().ShowDialog();
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e) => new HelpForm_KhrapkoDD().ShowDialog();
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}