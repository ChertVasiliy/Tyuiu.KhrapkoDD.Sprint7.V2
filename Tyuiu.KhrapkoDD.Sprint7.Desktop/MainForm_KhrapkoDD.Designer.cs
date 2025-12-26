namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class MainForm_KhrapkoDD
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ДИАГРАММА: используем ТОЛЬКО System.Windows.Forms.DataVisualization
            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            var legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            this.menuStripMain_KhrapkoDD = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStripMain_KhrapkoDD = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd_KhrapkoDD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit_KhrapkoDD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete_KhrapkoDD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStats_KhrapkoDD = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChart_KhrapkoDD = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch_KhrapkoDD = new System.Windows.Forms.ToolStripTextBox();

            this.dataGridViewPCs_KhrapkoDD = new System.Windows.Forms.DataGridView();
            this.bindingSourcePCs_KhrapkoDD = new System.Windows.Forms.BindingSource(this.components);

            this.chart1_KhrapkoDD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartArea1.Name = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart1_KhrapkoDD.ChartAreas.Add(chartArea1);
            this.chart1_KhrapkoDD.Legends.Add(legend1);
            this.chart1_KhrapkoDD.Location = new System.Drawing.Point(12, 320);
            this.chart1_KhrapkoDD.Name = "chart1_KhrapkoDD";
            this.chart1_KhrapkoDD.Size = new System.Drawing.Size(760, 200);
            this.chart1_KhrapkoDD.TabIndex = 10;
            this.chart1_KhrapkoDD.Visible = false;

            this.statusStripMain_KhrapkoDD = new System.Windows.Forms.StatusStrip();

            // Events
            this.toolStripButtonAdd_KhrapkoDD.Click += new System.EventHandler(this.buttonAdd_KhrapkoDD_Click);
            this.toolStripButtonEdit_KhrapkoDD.Click += new System.EventHandler(this.buttonEdit_KhrapkoDD_Click);
            this.toolStripButtonDelete_KhrapkoDD.Click += new System.EventHandler(this.buttonDelete_KhrapkoDD_Click);
            this.toolStripButtonStats_KhrapkoDD.Click += new System.EventHandler(this.buttonStats_KhrapkoDD_Click);
            this.toolStripButtonChart_KhrapkoDD.Click += new System.EventHandler(this.buttonChart_KhrapkoDD_Click);
            this.toolStripTextBoxSearch_KhrapkoDD.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_KhrapkoDD_TextChanged);
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);

            // Layout
            this.Controls.Add(this.chart1_KhrapkoDD);
            this.Controls.Add(this.dataGridViewPCs_KhrapkoDD);
            this.Controls.Add(this.toolStripMain_KhrapkoDD);
            this.Controls.Add(this.statusStripMain_KhrapkoDD);
            this.MainMenuStrip = this.menuStripMain_KhrapkoDD;
            this.Text = "Каталог ПК — Khrapko D.D.";
            this.Size = new System.Drawing.Size(800, 600);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPCs_KhrapkoDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePCs_KhrapkoDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_KhrapkoDD)).EndInit();
        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain_KhrapkoDD;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain_KhrapkoDD;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_KhrapkoDD;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit_KhrapkoDD;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete_KhrapkoDD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStats_KhrapkoDD;
        private System.Windows.Forms.ToolStripButton toolStripButtonChart_KhrapkoDD;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_KhrapkoDD;
        private System.Windows.Forms.DataGridView dataGridViewPCs_KhrapkoDD;
        private System.Windows.Forms.BindingSource bindingSourcePCs_KhrapkoDD;
        private System.Windows.Forms.StatusStrip statusStripMain_KhrapkoDD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_KhrapkoDD;
    }
}