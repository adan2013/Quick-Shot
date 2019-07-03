using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Quick_Shot
{
    static class Global
    {
        public enum AppMode
        {
            Crop,
            Editor
        }

        public enum CaptureZone
        {
            Desktop,
            DesktopWithoutBounds,
            Monitor,
            MonitorTihoutBounds,
            Window,
            ActiveWindow,
            CustomRegion
        }

        private static SettingsWindow sw;

        public static void OpenSettings()
        {
            if (sw != null && sw.IsVisible) return;
            sw = new SettingsWindow();
            sw.Show();
        }

        public static void ResetToggleButtons(StackPanel container)
        {
            foreach (Control c in container.Children)
            {
                if (c is ToggleButton) ((ToggleButton)c).IsChecked = false;
            }
        }
    }
}
