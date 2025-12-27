namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class MainForm_KhrapkoDD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_KhrapkoDD));
            menuStripMain_KhrapkoDD = new MenuStrip();
            toolStripMain_KhrapkoDD = new ToolStrip();
            toolStripButtonAdd_KhrapkoDD = new ToolStripButton();
            toolStripButtonEdit_KhrapkoDD = new ToolStripButton();
            toolStripButtonDelete_KhrapkoDD = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonStats_KhrapkoDD = new ToolStripButton();
            toolStripButtonChart_KhrapkoDD = new ToolStripButton();
            toolStripButtonRetailers_KhrapkoDD = new ToolStripButton();
            dataGridViewPCs_KhrapkoDD = new DataGridView();
            chart1_KhrapkoDD = new FastReport.DataVisualization.Charting.Chart();
            statusStripMain_KhrapkoDD = new StatusStrip();
            toolStripMain_KhrapkoDD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs_KhrapkoDD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1_KhrapkoDD).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_KhrapkoDD
            // 
            menuStripMain_KhrapkoDD.ImageScalingSize = new Size(20, 20);
            menuStripMain_KhrapkoDD.Location = new Point(0, 0);
            menuStripMain_KhrapkoDD.Name = "menuStripMain_KhrapkoDD";
            menuStripMain_KhrapkoDD.Size = new Size(800, 24);
            menuStripMain_KhrapkoDD.TabIndex = 0;
            menuStripMain_KhrapkoDD.Text = "menuStrip1";
            // 
            // toolStripMain_KhrapkoDD
            // 
            toolStripMain_KhrapkoDD.ImageScalingSize = new Size(20, 20);
            toolStripMain_KhrapkoDD.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd_KhrapkoDD, toolStripButtonEdit_KhrapkoDD, toolStripButtonDelete_KhrapkoDD, toolStripSeparator1, toolStripButtonStats_KhrapkoDD, toolStripButtonChart_KhrapkoDD, toolStripButtonRetailers_KhrapkoDD });
            toolStripMain_KhrapkoDD.Location = new Point(0, 24);
            toolStripMain_KhrapkoDD.Name = "toolStripMain_KhrapkoDD";
            toolStripMain_KhrapkoDD.Size = new Size(800, 27);
            toolStripMain_KhrapkoDD.TabIndex = 1;
            toolStripMain_KhrapkoDD.Text = "toolStrip1";
            // 
            // toolStripButtonAdd_KhrapkoDD
            // 
            toolStripButtonAdd_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonAdd_KhrapkoDD.Image");
            toolStripButtonAdd_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd_KhrapkoDD.Name = "toolStripButtonAdd_KhrapkoDD";
            toolStripButtonAdd_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonAdd_KhrapkoDD.Text = "toolStripButton1";
            toolStripButtonAdd_KhrapkoDD.Click += buttonAdd_KhrapkoDD_Click;
            // 
            // toolStripButtonEdit_KhrapkoDD
            // 
            toolStripButtonEdit_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEdit_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonEdit_KhrapkoDD.Image");
            toolStripButtonEdit_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit_KhrapkoDD.Name = "toolStripButtonEdit_KhrapkoDD";
            toolStripButtonEdit_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonEdit_KhrapkoDD.Text = "toolStripButton2";
            toolStripButtonEdit_KhrapkoDD.Click += buttonEdit_KhrapkoDD_Click;
            // 
            // toolStripButtonDelete_KhrapkoDD
            // 
            toolStripButtonDelete_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonDelete_KhrapkoDD.Image");
            toolStripButtonDelete_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_KhrapkoDD.Name = "toolStripButtonDelete_KhrapkoDD";
            toolStripButtonDelete_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonDelete_KhrapkoDD.Text = "toolStripButton3";
            toolStripButtonDelete_KhrapkoDD.Click += buttonDelete_KhrapkoDD_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButtonStats_KhrapkoDD
            // 
            toolStripButtonStats_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStats_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonStats_KhrapkoDD.Image");
            toolStripButtonStats_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonStats_KhrapkoDD.Name = "toolStripButtonStats_KhrapkoDD";
            toolStripButtonStats_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonStats_KhrapkoDD.Text = "toolStripButton4";
            toolStripButtonStats_KhrapkoDD.Click += buttonStats_KhrapkoDD_Click;
            // 
            // toolStripButtonChart_KhrapkoDD
            // 
            toolStripButtonChart_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonChart_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonChart_KhrapkoDD.Image");
            toolStripButtonChart_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonChart_KhrapkoDD.Name = "toolStripButtonChart_KhrapkoDD";
            toolStripButtonChart_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonChart_KhrapkoDD.Text = "toolStripButton5";
            toolStripButtonChart_KhrapkoDD.Click += buttonChart_KhrapkoDD_Click;
            // 
            // toolStripButtonRetailers_KhrapkoDD
            // 
            toolStripButtonRetailers_KhrapkoDD.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRetailers_KhrapkoDD.Image = (Image)resources.GetObject("toolStripButtonRetailers_KhrapkoDD.Image");
            toolStripButtonRetailers_KhrapkoDD.ImageTransparentColor = Color.Magenta;
            toolStripButtonRetailers_KhrapkoDD.Name = "toolStripButtonRetailers_KhrapkoDD";
            toolStripButtonRetailers_KhrapkoDD.Size = new Size(29, 24);
            toolStripButtonRetailers_KhrapkoDD.Text = "toolStripButton1";
            toolStripButtonRetailers_KhrapkoDD.Click += buttonRetailers_KhrapkoDD_Click;
            // 
            // dataGridViewPCs_KhrapkoDD
            // 
            dataGridViewPCs_KhrapkoDD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPCs_KhrapkoDD.Location = new Point(42, 89);
            dataGridViewPCs_KhrapkoDD.Name = "dataGridViewPCs_KhrapkoDD";
            dataGridViewPCs_KhrapkoDD.RowHeadersWidth = 51;
            dataGridViewPCs_KhrapkoDD.Size = new Size(553, 106);
            dataGridViewPCs_KhrapkoDD.TabIndex = 2;
            // 
            // chart1_KhrapkoDD
            // 
            chart1_KhrapkoDD.Location = new Point(42, 219);
            chart1_KhrapkoDD.Name = "chart1_KhrapkoDD";
            chart1_KhrapkoDD.Size = new Size(257, 99);
            chart1_KhrapkoDD.TabIndex = 3;
            chart1_KhrapkoDD.Text = "chart1";
            // 
            // statusStripMain_KhrapkoDD
            // 
            statusStripMain_KhrapkoDD.ImageScalingSize = new Size(20, 20);
            statusStripMain_KhrapkoDD.Location = new Point(0, 428);
            statusStripMain_KhrapkoDD.Name = "statusStripMain_KhrapkoDD";
            statusStripMain_KhrapkoDD.Size = new Size(800, 22);
            statusStripMain_KhrapkoDD.TabIndex = 4;
            statusStripMain_KhrapkoDD.Text = "statusStrip1";
            // 
            // MainForm_KhrapkoDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStripMain_KhrapkoDD);
            Controls.Add(chart1_KhrapkoDD);
            Controls.Add(dataGridViewPCs_KhrapkoDD);
            Controls.Add(toolStripMain_KhrapkoDD);
            Controls.Add(menuStripMain_KhrapkoDD);
            MainMenuStrip = menuStripMain_KhrapkoDD;
            Name = "MainForm_KhrapkoDD";
            Text = "MainForm_KhrapkoDD";
            toolStripMain_KhrapkoDD.ResumeLayout(false);
            toolStripMain_KhrapkoDD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs_KhrapkoDD).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1_KhrapkoDD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_KhrapkoDD;
        private ToolStrip toolStripMain_KhrapkoDD;
        private ToolStripButton toolStripButtonAdd_KhrapkoDD;
        private ToolStripButton toolStripButtonEdit_KhrapkoDD;
        private ToolStripButton toolStripButtonDelete_KhrapkoDD;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonStats_KhrapkoDD;
        private ToolStripButton toolStripButtonChart_KhrapkoDD;
        private ToolStripButton toolStripButtonRetailers_KhrapkoDD;
        private DataGridView dataGridViewPCs_KhrapkoDD;
        private FastReport.DataVisualization.Charting.Chart chart1_KhrapkoDD;
        private StatusStrip statusStripMain_KhrapkoDD;
    }
}