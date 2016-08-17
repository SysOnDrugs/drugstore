using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drugstoreapp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 headband = new Form1();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(2);
            headband.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            headband.Close();
            headband.Dispose();

            Application.Run(new auth());
        }
    }
}
