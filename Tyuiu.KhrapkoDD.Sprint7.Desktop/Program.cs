using System;
using System.Windows.Forms;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm_KhrapkoDD());
        }
    }
}
