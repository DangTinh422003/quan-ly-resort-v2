using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace quan_ly_resort_v2.utils
{
    public class DebounceHandler
    {
        private System.Windows.Forms.Timer debounceTimer = new System.Windows.Forms.Timer();
        private Action debounceAction;

        public DebounceHandler(int delay)
        {
            debounceTimer.Interval = delay;
            debounceTimer.Tick += new EventHandler(DebounceTimer_Tick);
        }

        public void Debounce(Action action)
        {
            debounceAction = action;
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceAction?.Invoke();
            debounceTimer.Stop();
        }
    }
}
