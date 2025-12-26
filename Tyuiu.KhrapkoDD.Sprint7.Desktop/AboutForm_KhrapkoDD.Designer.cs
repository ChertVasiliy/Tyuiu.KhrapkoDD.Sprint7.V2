namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class AboutForm_KhrapkoDD
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1.Text = "Каталог ПК v1.0\nАвтор: Khrapko D.D.\n2025";
            this.button1.Text = "OK";
            this.button1.Click += (s, e) => Close();
            this.Controls.AddRange(new Control[] { this.label1, this.button1 });
            this.Text = "О программе";
        }
        #endregion
    }
}