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

            // ПОДСКАЗКИ ДЛЯ ToolStrip: используем ToolTipText, а не ToolTip!
            toolStripButtonAdd_KhrapkoDD.ToolTipText = "Добавить новый ПК";
            toolStripButtonEdit_KhrapkoDD.ToolTipText = "Изменить выбранную запись";
            toolStripButtonDelete_KhrapkoDD.ToolTipText = "Удалить запись";
            toolStripButtonStats_KhrapkoDD.ToolTipText = "Показать статистику";
            toolStripButtonChart_KhrapkoDD.ToolTipText = "Показать гистограмму ОЗУ";
            

            LoadDataToGrid_KhrapkoDD();
        }

        private void LoadDataToGrid_KhrapkoDD()
        {
            var pcs = _dataService.LoadPcs();
           
           
            // dataGridViewPCs_KhrapkoDD.DataSource = bindingSourcePCs_KhrapkoDD;

            // СЧЁТЧИК ЗАПИСЕЙ: пока выводим в заголовок, так как StatusLabel отсутствует
            this.Text = $"Каталог ПК — Khrapko D.D. (Записей: {pcs.Count})";
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
            object value = chart.Series.Add(series); // ← Правильно: Series -> добавляется объект, не строка
            chart.Visible = true;
        }

        private void toolStripTextBoxSearch_KhrapkoDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm_KhrapkoDD().ShowDialog();
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e) => new HelpForm_KhrapkoDD().ShowDialog();
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}