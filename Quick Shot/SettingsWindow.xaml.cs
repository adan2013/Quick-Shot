using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quick_Shot
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            GoToPage(0);
        }

        private void TabButton_Click(object sender, RoutedEventArgs e)
        {
            GoToPage(int.Parse(((ToggleButton)sender).Tag.ToString()));
            Global.ResetToggleButtons(TabPanel);
            ((ToggleButton)sender).IsChecked = true;
        }

        public void GoToPage(int number)
        {
            switch(number)
            {
                case 0:
                    GoToPage(new GeneralSettingsPage());
                    break;
                case 1:
                    GoToPage(new KeyboardSettingsPage());
                    break;
                case 2:
                    GoToPage(new EditorSettingsPage());
                    break;
                case 3:
                    GoToPage(new OutputSettingsPage());
                    break;
                default:
                    GoToPage(new GeneralSettingsPage());
                    break;
            }
        }

        public void GoToPage(Page page)
        {
            settings_frame.Navigate(page);
        }
    }
}
