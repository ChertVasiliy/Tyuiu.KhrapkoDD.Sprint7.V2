using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Model;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class AddPcForm_KhrapkoDD : Form
    {
        public PersonalComputer_KhrapkoDD Pc { get; private set; }

        private readonly List<Retailer_KhrapkoDD> _retailers;
        private readonly bool _isEdit;

        public AddPcForm_KhrapkoDD(List<Retailer_KhrapkoDD> retailers,
                                   PersonalComputer_KhrapkoDD? pc = null)
        {
            _retailers = retailers;
            _isEdit = pc != null;
            Pc = pc ?? new PersonalComputer_KhrapkoDD { ReleaseDate = DateTime.Today };
            InitializeComponent();
            FillRetailers();
            BindPc();
            Text = _isEdit ? "Редактировать ПК" : "Добавить ПК";
        }

        private void FillRetailers()
        {
            comboBoxRetailer_KhrapkoDD.DataSource = _retailers;
            comboBoxRetailer_KhrapkoDD.DisplayMember = nameof(Retailer_KhrapkoDD.Name);
            comboBoxRetailer_KhrapkoDD.ValueMember = nameof(Retailer_KhrapkoDD.Id);
        }

        private void BindPc()
        {
            textBoxManufacturer_KhrapkoDD.DataBindings.Add("Text", Pc, nameof(Pc.Manufacturer), false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCpuType_KhrapkoDD.DataBindings.Add("Text", Pc, nameof(Pc.CpuType));
            numericUpDownFreq_KhrapkoDD.DataBindings.Add("Value", Pc, nameof(Pc.CpuFrequencyMHz));
            numericUpDownRam_KhrapkoDD.DataBindings.Add("Value", Pc, nameof(Pc.RamGb));
            numericUpDownHdd_KhrapkoDD.DataBindings.Add("Value", Pc, nameof(Pc.HddGb));
            dateTimePickerRel_KhrapkoDD.DataBindings.Add("Value", Pc, nameof(Pc.ReleaseDate));
            comboBoxRetailer_KhrapkoDD.DataBindings.Add("SelectedValue", Pc, nameof(Pc.RetailerId));
        }

        private void buttonSave_KhrapkoDD_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void InitializeComponent()
        {
            comboBoxRetailer_KhrapkoDD = new ComboBox();
            dateTimePickerRel_KhrapkoDD = new DateTimePicker();
            numericUpDownFreq_KhrapkoDD = new NumericUpDown();
            textBoxManufacturer_KhrapkoDD = new TextBox();
            textBoxCpuType_KhrapkoDD = new TextBox();
            numericUpDownHdd_KhrapkoDD = new NumericUpDown();
            numericUpDownRam_KhrapkoDD = new NumericUpDown();
            ((ISupportInitialize)numericUpDownFreq_KhrapkoDD).BeginInit();
            ((ISupportInitialize)numericUpDownHdd_KhrapkoDD).BeginInit();
            ((ISupportInitialize)numericUpDownRam_KhrapkoDD).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRetailer_KhrapkoDD
            // 
            comboBoxRetailer_KhrapkoDD.FormattingEnabled = true;
            comboBoxRetailer_KhrapkoDD.Location = new Point(21, 29);
            comboBoxRetailer_KhrapkoDD.Name = "comboBoxRetailer_KhrapkoDD";
            comboBoxRetailer_KhrapkoDD.Size = new Size(173, 28);
            comboBoxRetailer_KhrapkoDD.TabIndex = 0;
            // 
            // dateTimePickerRel_KhrapkoDD
            // 
            dateTimePickerRel_KhrapkoDD.Location = new Point(258, 42);
            dateTimePickerRel_KhrapkoDD.Name = "dateTimePickerRel_KhrapkoDD";
            dateTimePickerRel_KhrapkoDD.Size = new Size(190, 27);
            dateTimePickerRel_KhrapkoDD.TabIndex = 1;
            // 
            // numericUpDownFreq_KhrapkoDD
            // 
            numericUpDownFreq_KhrapkoDD.Location = new Point(50, 98);
            numericUpDownFreq_KhrapkoDD.Name = "numericUpDownFreq_KhrapkoDD";
            numericUpDownFreq_KhrapkoDD.Size = new Size(94, 27);
            numericUpDownFreq_KhrapkoDD.TabIndex = 2;
            // 
            // textBoxManufacturer_KhrapkoDD
            // 
            textBoxManufacturer_KhrapkoDD.Location = new Point(33, 146);
            textBoxManufacturer_KhrapkoDD.Name = "textBoxManufacturer_KhrapkoDD";
            textBoxManufacturer_KhrapkoDD.Size = new Size(311, 27);
            textBoxManufacturer_KhrapkoDD.TabIndex = 3;
            // 
            // textBoxCpuType_KhrapkoDD
            // 
            textBoxCpuType_KhrapkoDD.Location = new Point(12, 233);
            textBoxCpuType_KhrapkoDD.Name = "textBoxCpuType_KhrapkoDD";
            textBoxCpuType_KhrapkoDD.Size = new Size(226, 27);
            textBoxCpuType_KhrapkoDD.TabIndex = 4;
            // 
            // numericUpDownHdd_KhrapkoDD
            // 
            numericUpDownHdd_KhrapkoDD.Location = new Point(312, 194);
            numericUpDownHdd_KhrapkoDD.Name = "numericUpDownHdd_KhrapkoDD";
            numericUpDownHdd_KhrapkoDD.Size = new Size(121, 27);
            numericUpDownHdd_KhrapkoDD.TabIndex = 5;
            // 
            // numericUpDownRam_KhrapkoDD
            // 
            numericUpDownRam_KhrapkoDD.Location = new Point(297, 253);
            numericUpDownRam_KhrapkoDD.Name = "numericUpDownRam_KhrapkoDD";
            numericUpDownRam_KhrapkoDD.Size = new Size(126, 27);
            numericUpDownRam_KhrapkoDD.TabIndex = 6;
            // 
            // AddPcForm_KhrapkoDD
            // 
            ClientSize = new Size(641, 356);
            Controls.Add(numericUpDownRam_KhrapkoDD);
            Controls.Add(numericUpDownHdd_KhrapkoDD);
            Controls.Add(textBoxCpuType_KhrapkoDD);
            Controls.Add(textBoxManufacturer_KhrapkoDD);
            Controls.Add(numericUpDownFreq_KhrapkoDD);
            Controls.Add(dateTimePickerRel_KhrapkoDD);
            Controls.Add(comboBoxRetailer_KhrapkoDD);
            Name = "AddPcForm_KhrapkoDD";
            ((ISupportInitialize)numericUpDownFreq_KhrapkoDD).EndInit();
            ((ISupportInitialize)numericUpDownHdd_KhrapkoDD).EndInit();
            ((ISupportInitialize)numericUpDownRam_KhrapkoDD).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private ComboBox comboBoxRetailer_KhrapkoDD;
        private DateTimePicker dateTimePickerRel_KhrapkoDD;
        private NumericUpDown numericUpDownFreq_KhrapkoDD;
        private TextBox textBoxManufacturer_KhrapkoDD;
        private TextBox textBoxCpuType_KhrapkoDD;
        private NumericUpDown numericUpDownHdd_KhrapkoDD;
        private NumericUpDown numericUpDownRam_KhrapkoDD;
    }
}