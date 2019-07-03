using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WinForms = System.Windows.Forms;

namespace Quick_Shot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        System.Windows.Forms.NotifyIcon notifyicon;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            new System.Threading.Mutex(true, "Quick Shot", out bool createdNew);
            if (!createdNew)
            {
                MessageBox.Show("App is already running!", "Quick Shot", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK);
                Environment.Exit(0);
            }

            notifyicon = new System.Windows.Forms.NotifyIcon
            {
                Icon = new System.Drawing.Icon(GetResourceStream(new Uri("pack://application:,,,/Icons/nicon.ico")).Stream),
                ContextMenu = CreateIconContextMenu(),
                Visible = true
            };
            notifyicon.Click += new EventHandler(OpenSettings);

            //HotKeyManager.RegisterHotKey(System.Windows.Forms.Keys.X, KeyModifiers.Alt);
            //HotKeyManager.RegisterHotKey(System.Windows.Forms.Keys.N, KeyModifiers.Windows);
            //HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressed;

            //System.Threading.Thread.Sleep(4000);
            //string temp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\temp.bmp";
            //Capture cap = new Capture();
            //cap.CaptureActiveWindow().Save(temp);
            //System.Diagnostics.Process.Start(temp);
            //Environment.Exit(0);

            Global.OpenSettings();
        }
        
        private WinForms.ContextMenu CreateIconContextMenu()
        {
            WinForms.ContextMenu cm = new WinForms.ContextMenu();
            cm.MenuItems.Add(new WinForms.MenuItem("Capture main screen", new EventHandler(CloseApp)));
            cm.MenuItems.Add(new WinForms.MenuItem("-"));
            cm.MenuItems.Add(new WinForms.MenuItem("&Settings", new EventHandler(OpenSettings)));
            cm.MenuItems.Add(new WinForms.MenuItem("&Quit", new EventHandler(CloseApp)));
            return cm;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Global.OpenSettings();
        }
    }
}
