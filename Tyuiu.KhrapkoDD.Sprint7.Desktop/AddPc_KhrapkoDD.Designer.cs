
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;


namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class ChartForm_KhrapkoDD : Form
    {
        public ChartForm_KhrapkoDD(List<(string Manufacturer, int Qty)> data)
        {
            InitializeComponent();
            chart1_KhrapkoDD.Series.Clear();
            var serie = new Series("Manufacturer")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            foreach (var (m, q) in data)
                serie.Points.AddXY(m, q);
            chart1_KhrapkoDD.Series.Add(serie);
            chart1_KhrapkoDD.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            Text = "Распределение ПК по производителям";
        }
    }
}