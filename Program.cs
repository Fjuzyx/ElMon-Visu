using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace EnMon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Test na poskozeni souboru nastaveni.
                if (Properties.Settings.Default.PVILocalIP == null)
                {
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("Konfigurační soubor je poškozen!\nProgram se restartujte, poté proveďte nové nastavení.");

                string filename = ((ConfigurationErrorsException)ex.InnerException).Filename;
                File.Delete(filename);

                Application.Restart();
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filePath = Path.Combine(Application.CommonAppDataPath, "Log");
            Directory.CreateDirectory(filePath);
            log4net.GlobalContext.Properties["LogPath"] = filePath;
            log4net.Config.XmlConfigurator.Configure();

            Application.Run(new frmMain());
        }
    }
}
