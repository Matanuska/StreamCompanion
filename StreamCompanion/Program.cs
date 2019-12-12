using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicNP.CryptoLicensing;
using System.Threading;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace StreamCompanion
{
    static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "StreamCompanion";
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            { 
                ResourceManager rm = new ResourceManager("StreamCompanion.MainForm", Assembly.GetExecutingAssembly());
                String str = rm.GetString("singleinstancewarning",CultureInfo.CurrentCulture);
                MessageBox.Show(str);
                return;
            }

               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);



            /*
             * Standard 10 jours
                FgSAgPTVvzKYoNUBCgABARApMzaTcUoNV4kDZrbPcjE70G4oGUX1U4ljWINIUtu+SbsZ0kSI64rdjuLp1vWX5eI=

                Pro 10 jours
                FgSAgLWk20OYoNUBCgABAhBqeKEkm6BPTGk11ca4MFesDswsTSvIYQtLyjaSsCoAMKim2PBYk3nP4w8o4k60bCc=

                Pro no limits
                FgCAgDJmwVOYoNUBAQIQJahUJdgWCfCD1J/6V2pZSmqIHDC0jIUQaTOP6ipG5f7P/1mHkyMvXDq1V61XzjmC
             */

            string validationKey = "AMAAMACDq7YAhOTWIkO+7tmgmGfnwVoi7zJeoEFDqefYYGYtjoOqI4u4q6EAsFlza7leiicDAAEAAQ==";
            

            CryptoLicense license = new CryptoLicense("FgSAgPTVvzKYoNUBCgABARApMzaTcUoNV4kDZrbPcjE70G4oGUX1U4ljWINIUtu+SbsZ0kSI64rdjuLp1vWX5eI=", validationKey);
          // if (license.Status != LicenseStatus.Valid)
          // {
          //     MessageBox.Show("License validation failed");
          // }
          // else
          // {
                // Continue normal execution...
                Application.Run(new MainForm(license));                
           // }
           

            
        }
    }
}
