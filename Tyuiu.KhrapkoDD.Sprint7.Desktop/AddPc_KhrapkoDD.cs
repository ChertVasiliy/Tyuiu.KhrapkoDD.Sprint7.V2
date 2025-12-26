using System;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    public partial class AddPcForm_KhrapkoDD : Form
    {
        public PersonalComputer_KhrapkoDD? CreatedPc { get; private set; }

        public AddPcForm_KhrapkoDD(PersonalComputer_KhrapkoDD? pc = null)
        {
            InitializeComponent();
            if (pc != null)
            {
                textBoxManufacturer_KhrapkoDD.Text = pc.Manufacturer;
                textBoxCpuType_KhrapkoDD.Text = pc.CpuType;
                numericUpDownFreq_KhrapkoDD.Value = (decimal)pc.ClockSpeedGHz;
                numericUpDownRam_KhrapkoDD.Value = pc.RamGb;
                numericUpDownHdd_KhrapkoDD.Value = pc.HddGb;
                dateTimePickerRel_KhrapkoDD.Value = pc.ReleaseDate;
            }
        }

        private void buttonSave_KhrapkoDD_Click(object sender, EventArgs e)
        {
            CreatedPc = new PersonalComputer_KhrapkoDD
            {
                Manufacturer = textBoxManufacturer_KhrapkoDD.Text,
                CpuType = textBoxCpuType_KhrapkoDD.Text,
                ClockSpeedGHz = (double)numericUpDownFreq_KhrapkoDD.Value,
                RamGb = (int)numericUpDownRam_KhrapkoDD.Value,
                HddGb = (int)numericUpDownHdd_KhrapkoDD.Value,
                ReleaseDate = dateTimePickerRel_KhrapkoDD.Value
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_KhrapkoDD_Click(object sender, EventArgs e) => Close();
    }
}