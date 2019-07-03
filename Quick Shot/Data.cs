using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Shot
{
    static class Data
    {
        #region "SETTINGS"
        private static SettingsContainer settings;

        public static SettingsContainer GetSettings()
        {
            if (settings == null) settings = new SettingsContainer();
            return settings;
        }

        public static bool LoadSettings()
        {
            //TODO load settings
            return true;
        }

        public static bool SaveSettings()
        {
            //TODO save settings
            return true;
        }
        #endregion

        #region "EDITOR MODE DATA"
        private static EditorModeData editormodedata;

        public static EditorModeData GetEditorModeData()
        {
            if (editormodedata == null) editormodedata = new EditorModeData();
            return editormodedata;
        }

        public static void ResetEditorMode()
        {
            editormodedata = new EditorModeData();
        }
        #endregion

        #region "CROP MODE DATA"
        private static CropModeData cropmodedata;

        public static CropModeData GetCropModeData()
        {
            if (cropmodedata == null) cropmodedata = new CropModeData();
            return cropmodedata;
        }

        public static void ResetCropMode()
        {
            cropmodedata = new CropModeData();
        }
        #endregion
    }
}
