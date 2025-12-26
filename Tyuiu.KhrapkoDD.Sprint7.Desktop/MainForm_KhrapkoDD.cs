using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Model;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Services;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class MainForm_KhrapkoDD : Form
    {
        private readonly CsvDataService_KhrapkoDD _dataService;
        private readonly StatisticsService_KhrapkoDD _statService;
        private List<PersonalComputer_KhrapkoDD> _fullList = new();
        private BindingSource _bs = new();

        public MainForm_KhrapkoDD(string dataFolder)
        {
            InitializeComponent();
            _dataService = new CsvDataService_KhrapkoDD(dataFolder);
            _statService = new StatisticsService_KhrapkoDD();
            bindingSourcePCs_KhrapkoDD.DataSource = _fullList;
            dataGridViewPCs_KhrapkoDD.DataSource = bindingSourcePCs_KhrapkoDD;
            LoadDataToGrid_KhrapkoDD();
        }

        /* ---------- CRUD ---------- */
        private void LoadDataToGrid_KhrapkoDD()
        {
            _fullList = _dataService.LoadPcs();
            _bs.DataSource = null;
            _bs.DataSource = _fullList;
            Text = $"Персональные ЭВМ – Храпко Д.Д. – Всего записей: {_fullList.Count}";
        }

        private void AddPc_KhrapkoDD()
        {
            var frm = new AddPcForm_KhrapkoDD(_dataService.LoadRetailers());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _fullList.Add(frm.Pc);
                SaveAndReload();
            }
        }

        private void EditPc_KhrapkoDD()
        {
            if (bindingSourcePCs_KhrapkoDD.Current is PersonalComputer_KhrapkoDD pc)
            {
                var frm = new AddPcForm_KhrapkoDD(_dataService.LoadRetailers(), pc);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SaveAndReload();
                }
            }
        }

        private void DeletePc_KhrapkoDD()
        {
            if (bindingSourcePCs_KhrapkoDD.Current is PersonalComputer_KhrapkoDD pc)
            {
                if (MessageBox.Show($"Удалить ПК '{pc.Manufacturer}' ?", "Подтверждение",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _fullList.Remove(pc);
                    SaveAndReload();
                }
            }
        }

        private void SaveAndReload()
        {
            _dataService.SavePcs(_fullList);
            LoadDataToGrid_KhrapkoDD();
        }

        /* ---------- Поиск / фильтр ---------- */
        private void ApplyFilter_KhrapkoDD()
        {
            var key = toolStripTextBoxSearch_KhrapkoDD.Text.Trim().ToLower();
            var filtered = _fullList.Where(p =>
                p.Manufacturer.ToLower().Contains(key) ||
                p.CpuType.ToLower().Contains(key)).ToList();
            _bs.DataSource = filtered;
        }

        /* ---------- Статистика ---------- */
        private void ShowStats_KhrapkoDD()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"Всего ПК: {_statService.Count(_fullList)}");
            sb.AppendLine($"Суммарно ОЗУ (ГБ): {_statService.TotalRam(_fullList)}");
            sb.AppendLine($"Средняя частота (МГц): {_statService.AvgFrequency(_fullList):F0}");
            sb.AppendLine($"Мин / Max HDD (ГБ): {_statService.MinHdd(_fullList)} / {_statService.MaxHdd(_fullList)}");
            MessageBox.Show(sb.ToString(), "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* ---------- График ---------- */
        private void ShowChart_KhrapkoDD()
        {
            var data = _statService.GroupByManufacturer(_fullList);
            var chartFrm = new ChartForm_KhrapkoDD(data);
            chartFrm.ShowDialog();
        }
    }
}
