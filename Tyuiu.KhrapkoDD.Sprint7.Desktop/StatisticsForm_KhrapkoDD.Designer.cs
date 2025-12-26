namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class StatisticsForm_KhrapkoDD
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
            labelCount_KhrapkoDD = new Label();
            labelMaxClock_KhrapkoDD = new Label();
            labelTotalHdd_KhrapkoDD = new Label();
            labelMaxRam_KhrapkoDD = new Label();
            labelMinRam_KhrapkoDD = new Label();
            labelAvgRam_KhrapkoDD = new Label();
            SuspendLayout();
            // 
            // labelCount_KhrapkoDD
            // 
            labelCount_KhrapkoDD.AutoSize = true;
            labelCount_KhrapkoDD.Location = new Point(40, 29);
            labelCount_KhrapkoDD.Name = "labelCount_KhrapkoDD";
            labelCount_KhrapkoDD.Size = new Size(50, 20);
            labelCount_KhrapkoDD.TabIndex = 0;
            labelCount_KhrapkoDD.Text = "label1";
            // 
            // labelMaxClock_KhrapkoDD
            // 
            labelMaxClock_KhrapkoDD.AutoSize = true;
            labelMaxClock_KhrapkoDD.Location = new Point(40, 129);
            labelMaxClock_KhrapkoDD.Name = "labelMaxClock_KhrapkoDD";
            labelMaxClock_KhrapkoDD.Size = new Size(50, 20);
            labelMaxClock_KhrapkoDD.TabIndex = 1;
            labelMaxClock_KhrapkoDD.Text = "label2";
            // 
            // labelTotalHdd_KhrapkoDD
            // 
            labelTotalHdd_KhrapkoDD.AutoSize = true;
            labelTotalHdd_KhrapkoDD.Location = new Point(40, 109);
            labelTotalHdd_KhrapkoDD.Name = "labelTotalHdd_KhrapkoDD";
            labelTotalHdd_KhrapkoDD.Size = new Size(50, 20);
            labelTotalHdd_KhrapkoDD.TabIndex = 2;
            labelTotalHdd_KhrapkoDD.Text = "label3";
            // 
            // labelMaxRam_KhrapkoDD
            // 
            labelMaxRam_KhrapkoDD.AutoSize = true;
            labelMaxRam_KhrapkoDD.Location = new Point(40, 89);
            labelMaxRam_KhrapkoDD.Name = "labelMaxRam_KhrapkoDD";
            labelMaxRam_KhrapkoDD.Size = new Size(50, 20);
            labelMaxRam_KhrapkoDD.TabIndex = 3;
            labelMaxRam_KhrapkoDD.Text = "label4";
            // 
            // labelMinRam_KhrapkoDD
            // 
            labelMinRam_KhrapkoDD.AutoSize = true;
            labelMinRam_KhrapkoDD.Location = new Point(40, 69);
            labelMinRam_KhrapkoDD.Name = "labelMinRam_KhrapkoDD";
            labelMinRam_KhrapkoDD.Size = new Size(50, 20);
            labelMinRam_KhrapkoDD.TabIndex = 4;
            labelMinRam_KhrapkoDD.Text = "label5";
            // 
            // labelAvgRam_KhrapkoDD
            // 
            labelAvgRam_KhrapkoDD.AutoSize = true;
            labelAvgRam_KhrapkoDD.Location = new Point(40, 49);
            labelAvgRam_KhrapkoDD.Name = "labelAvgRam_KhrapkoDD";
            labelAvgRam_KhrapkoDD.Size = new Size(50, 20);
            labelAvgRam_KhrapkoDD.TabIndex = 5;
            labelAvgRam_KhrapkoDD.Text = "label6";
            // 
            // StatisticsForm_KhrapkoDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 374);
            Controls.Add(labelAvgRam_KhrapkoDD);
            Controls.Add(labelMinRam_KhrapkoDD);
            Controls.Add(labelMaxRam_KhrapkoDD);
            Controls.Add(labelTotalHdd_KhrapkoDD);
            Controls.Add(labelMaxClock_KhrapkoDD);
            Controls.Add(labelCount_KhrapkoDD);
            Name = "StatisticsForm_KhrapkoDD";
            Text = "StatisticsForm_KhrapkoDD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCount_KhrapkoDD;
        private Label labelMaxClock_KhrapkoDD;
        private Label labelTotalHdd_KhrapkoDD;
        private Label labelMaxRam_KhrapkoDD;
        private Label labelMinRam_KhrapkoDD;
        private Label labelAvgRam_KhrapkoDD;
    }
}