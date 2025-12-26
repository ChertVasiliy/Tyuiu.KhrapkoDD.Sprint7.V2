namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    partial class AboutForm_KhrapkoDD
    {
        private System.ComponentModel.IContainer components = null;

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
            PictureBox pictureBoxLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm_KhrapkoDD));
            label1 = new Label();
            button1 = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 22);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(139, 106);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 22);
            label1.Name = "label1";
            label1.Size = new Size(145, 80);
            label1.TabIndex = 1;
            label1.Text = "Каталог ПК v1.0\r\nАвтор: Khrapko D.D.\r\n2025\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 148);
            button1.Name = "button1";
            button1.Size = new Size(142, 44);
            button1.TabIndex = 2;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AboutForm_KhrapkoDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(369, 200);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm_KhrapkoDD";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            Load += AboutForm_KhrapkoDD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}