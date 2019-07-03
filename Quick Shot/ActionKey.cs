using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Shot
{
    class ActionKey
    {
        const int MAX_DELAY = 5000;

        public Keys ShortcutKey
        {
            get { return _shortcutkey; }
            set
            {
                //TODO unregister
                _shortcutkey = value;
            }
        }
        public KeyModifiers ShortcutModifiers
        {
            get { return _shortcutmodifiers; }
            set
            {
                //TODO unregister
                _shortcutmodifiers = value;
            }
        }
        public int Delay
        {
            get { return _delay; }
            set
            {
                if (value < 0) value = 0;
                if (value > MAX_DELAY) value = MAX_DELAY;
                _delay = value;
            }
        }
        public Global.AppMode ApplicationMode;
        public Global.CaptureZone ScreenZone;

        private Keys _shortcutkey;
        private KeyModifiers _shortcutmodifiers;
        private int _delay;

        public void Execute()
        {

        }
    }
}
