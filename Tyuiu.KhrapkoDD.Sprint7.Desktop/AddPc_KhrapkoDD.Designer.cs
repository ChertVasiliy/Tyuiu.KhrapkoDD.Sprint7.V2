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
            this.textBoxManufacturer_KhrapkoDD = new System.Windows.Forms.TextBox();
            this.textBoxCpuType_KhrapkoDD = new System.Windows.Forms.TextBox();
            this.numericUpDownFreq_KhrapkoDD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRam_KhrapkoDD = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHdd_KhrapkoDD = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerRel_KhrapkoDD = new System.Windows.Forms.DateTimePicker();
            this.buttonSave_KhrapkoDD = new System.Windows.Forms.Button();
            this.buttonCancel_KhrapkoDD = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq_KhrapkoDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRam_KhrapkoDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdd_KhrapkoDD)).BeginInit();

            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.textBoxManufacturer_KhrapkoDD,
                this.textBoxCpuType_KhrapkoDD,
                this.numericUpDownFreq_KhrapkoDD,
                this.numericUpDownRam_KhrapkoDD,
                this.numericUpDownHdd_KhrapkoDD,
                this.dateTimePickerRel_KhrapkoDD,
                this.buttonSave_KhrapkoDD,
                this.buttonCancel_KhrapkoDD
            });

            this.buttonSave_KhrapkoDD.Click += new System.EventHandler(this.buttonSave_KhrapkoDD_Click);
            this.buttonCancel_KhrapkoDD.Click += new System.EventHandler(this.buttonCancel_KhrapkoDD_Click);

            this.Text = "ПК: Добавить/Редактировать";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq_KhrapkoDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRam_KhrapkoDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdd_KhrapkoDD)).EndInit();
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
    }
}