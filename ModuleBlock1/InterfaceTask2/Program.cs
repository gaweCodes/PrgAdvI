﻿using System;
using System.Windows.Forms;
using InterfaceTask2.View;

namespace InterfaceTask2
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
