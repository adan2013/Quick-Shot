using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Quick_Shot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            new System.Threading.Mutex(true, "Quick Shot", out bool createdNew);
            if (!createdNew)
            {
                MessageBox.Show("App is already running!", "Quick Shot", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
                Environment.Exit(0);
            }

            //HotKeyManager.RegisterHotKey(System.Windows.Forms.Keys.X, KeyModifiers.Alt);
            //HotKeyManager.RegisterHotKey(System.Windows.Forms.Keys.N, KeyModifiers.Windows);
            //HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressed;

            //System.Threading.Thread.Sleep(4000);
            //string temp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\temp.bmp";
            //Capture cap = new Capture();
            //cap.CaptureActiveWindow().Save(temp);
            //System.Diagnostics.Process.Start(temp);
            //Environment.Exit(0);
        }

        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("HOTKEY! {0} {1}", e.Key.ToString(), e.Modifiers.ToString());
        }
    }
}
