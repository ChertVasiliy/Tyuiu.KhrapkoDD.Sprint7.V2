using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class MainForm_KhrapkoDD : Form
    {
        public MainForm_KhrapkoDD()
        {
            InitializeComponent();
            _dataService = new CsvDataService_KhrapkoDD(@"Data\pcs_KhrapkoDD.csv", @"Data\retailers_KhrapkoDD.csv");
            _toolTip = new ToolTip(); // ← инициализация в конструкторе — ОБЯЗАТЕЛЬНО
            SetupTooltips_KhrapkoDD();
            LoadDataToGrid_KhrapkoDD();
        }

        private void SetupTooltips_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonAdd_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }

        private void buttonStats_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }

        private void buttonChart_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetailers_KhrapkoDD_Click(object sender, EventArgs e)
        {

        }
    }
}
