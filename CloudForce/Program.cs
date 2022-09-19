using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudForce
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists("B:\\CloudForce"))
            {
                try
                {
                    Directory.CreateDirectory("B:\\CloudForce");
                } catch
                {
                    MessageBox.Show("!Warning B Drive not avaiable!");
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
