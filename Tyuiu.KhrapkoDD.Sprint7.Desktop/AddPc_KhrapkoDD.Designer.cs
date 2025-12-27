namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class AddPcForm_KhrapkoDD
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
            textBoxManufacturer_KhrapkoDD = new TextBox();
            textBoxCpuType_KhrapkoDD = new TextBox();
            numericUpDownFreq_KhrapkoDD = new NumericUpDown();
            numericUpDownRam_KhrapkoDD = new NumericUpDown();
            numericUpDownHdd_KhrapkoDD = new NumericUpDown();
            dateTimePickerRel_KhrapkoDD = new DateTimePicker();
            buttonSave_KhrapkoDD = new Button();
            buttonCancel_KhrapkoDD = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreq_KhrapkoDD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRam_KhrapkoDD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHdd_KhrapkoDD).BeginInit();
            SuspendLayout();
            // 
            // textBoxManufacturer_KhrapkoDD
            // 
            textBoxManufacturer_KhrapkoDD.Location = new Point(12, 177);
            textBoxManufacturer_KhrapkoDD.Name = "textBoxManufacturer_KhrapkoDD";
            textBoxManufacturer_KhrapkoDD.Size = new Size(100, 27);
            textBoxManufacturer_KhrapkoDD.TabIndex = 0;
            // 
            // textBoxCpuType_KhrapkoDD
            // 
            textBoxCpuType_KhrapkoDD.Location = new Point(12, 111);
            textBoxCpuType_KhrapkoDD.Name = "textBoxCpuType_KhrapkoDD";
            textBoxCpuType_KhrapkoDD.Size = new Size(100, 27);
            textBoxCpuType_KhrapkoDD.TabIndex = 1;
            // 
            // numericUpDownFreq_KhrapkoDD
            // 
            numericUpDownFreq_KhrapkoDD.Location = new Point(12, 144);
            numericUpDownFreq_KhrapkoDD.Name = "numericUpDownFreq_KhrapkoDD";
            numericUpDownFreq_KhrapkoDD.Size = new Size(120, 27);
            numericUpDownFreq_KhrapkoDD.TabIndex = 2;
            // 
            // numericUpDownRam_KhrapkoDD
            // 
            numericUpDownRam_KhrapkoDD.Location = new Point(12, 78);
            numericUpDownRam_KhrapkoDD.Name = "numericUpDownRam_KhrapkoDD";
            numericUpDownRam_KhrapkoDD.Size = new Size(120, 27);
            numericUpDownRam_KhrapkoDD.TabIndex = 3;
            // 
            // numericUpDownHdd_KhrapkoDD
            // 
            numericUpDownHdd_KhrapkoDD.Location = new Point(12, 45);
            numericUpDownHdd_KhrapkoDD.Name = "numericUpDownHdd_KhrapkoDD";
            numericUpDownHdd_KhrapkoDD.Size = new Size(120, 27);
            numericUpDownHdd_KhrapkoDD.TabIndex = 4;
            // 
            // dateTimePickerRel_KhrapkoDD
            // 
            dateTimePickerRel_KhrapkoDD.Location = new Point(12, 12);
            dateTimePickerRel_KhrapkoDD.Name = "dateTimePickerRel_KhrapkoDD";
            dateTimePickerRel_KhrapkoDD.Size = new Size(200, 27);
            dateTimePickerRel_KhrapkoDD.TabIndex = 5;
            // 
            // buttonSave_KhrapkoDD
            // 
            buttonSave_KhrapkoDD.Location = new Point(298, 207);
            buttonSave_KhrapkoDD.Name = "buttonSave_KhrapkoDD";
            buttonSave_KhrapkoDD.Size = new Size(75, 33);
            buttonSave_KhrapkoDD.TabIndex = 6;
            buttonSave_KhrapkoDD.Text = "сохр";
            buttonSave_KhrapkoDD.Click += buttonSave_KhrapkoDD_Click;
            // 
            // buttonCancel_KhrapkoDD
            // 
            buttonCancel_KhrapkoDD.Location = new Point(217, 207);
            buttonCancel_KhrapkoDD.Name = "buttonCancel_KhrapkoDD";
            buttonCancel_KhrapkoDD.Size = new Size(75, 33);
            buttonCancel_KhrapkoDD.TabIndex = 7;
            buttonCancel_KhrapkoDD.Text = "выход";
            buttonCancel_KhrapkoDD.Click += buttonCancel_KhrapkoDD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 120);
            label1.TabIndex = 8;
            label1.Text = "дата сборки\r\nhdd\r\nRam\r\nназв проц\r\nГЦ\r\nпроизв";
            // 
            // AddPcForm_KhrapkoDD
            // 
            ClientSize = new Size(385, 244);
            Controls.Add(label1);
            Controls.Add(textBoxManufacturer_KhrapkoDD);
            Controls.Add(textBoxCpuType_KhrapkoDD);
            Controls.Add(numericUpDownFreq_KhrapkoDD);
            Controls.Add(numericUpDownRam_KhrapkoDD);
            Controls.Add(numericUpDownHdd_KhrapkoDD);
            Controls.Add(dateTimePickerRel_KhrapkoDD);
            Controls.Add(buttonSave_KhrapkoDD);
            Controls.Add(buttonCancel_KhrapkoDD);
            Name = "AddPcForm_KhrapkoDD";
            Text = "ПК: Добавить/Редактировать";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreq_KhrapkoDD).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRam_KhrapkoDD).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHdd_KhrapkoDD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox textBoxManufacturer_KhrapkoDD;
        private System.Windows.Forms.TextBox textBoxCpuType_KhrapkoDD;
        private System.Windows.Forms.NumericUpDown numericUpDownFreq_KhrapkoDD;
        private System.Windows.Forms.NumericUpDown numericUpDownRam_KhrapkoDD;
        private System.Windows.Forms.NumericUpDown numericUpDownHdd_KhrapkoDD;
        private System.Windows.Forms.DateTimePicker dateTimePickerRel_KhrapkoDD;
        private System.Windows.Forms.Button buttonSave_KhrapkoDD;
        private System.Windows.Forms.Button buttonCancel_KhrapkoDD;
        private Label label1;
    }
}