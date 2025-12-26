using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class StatisticsForm_KhrapkoDD : Form
    {
        public StatisticsForm_KhrapkoDD(System.Collections.Generic.List<PersonalComputer_KhrapkoDD> pcs)
        {
            InitializeComponent();
            if (pcs.Count == 0) return;

            labelCount_KhrapkoDD.Text = $"Количество ПК: {pcs.Count}";
            labelAvgRam_KhrapkoDD.Text = $"Среднее ОЗУ: {pcs.Average(p => p.RamGb):F1} ГБ";
            labelMinRam_KhrapkoDD.Text = $"Мин. ОЗУ: {pcs.Min(p => p.RamGb)} ГБ";
            labelMaxRam_KhrapkoDD.Text = $"Макс. ОЗУ: {pcs.Max(p => p.RamGb)} ГБ";
            labelTotalHdd_KhrapkoDD.Text = $"Суммарный HDD: {pcs.Sum(p => p.HddGb)} ГБ";
            labelMaxClock_KhrapkoDD.Text = $"Макс. частота CPU: {pcs.Max(p => p.ClockSpeedGHz)} ГГц";
        }
    }
}
