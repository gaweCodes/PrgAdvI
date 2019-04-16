using System;
using System.Windows.Forms;
using InterfaceTask3.View;

namespace InterfaceTask3
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
