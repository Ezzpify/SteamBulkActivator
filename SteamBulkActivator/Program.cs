using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;

namespace SteamBulkActivator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                        | SecurityProtocolType.Tls11
                        | SecurityProtocolType.Tls12
                        | SecurityProtocolType.Ssl3;

            try
            {
                /*We need to register the application under Internet Explorer emulation registry key. Not doing this would cause the Steam Login web browser to render the css all wonky.*/
                RegistryKey ie_root = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(AppDomain.CurrentDomain.FriendlyName, 10001, RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Browser emulation failed. Websites loaded might appear wonky.", "Emulation failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
