using AlarmeClock2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmeClock2.Models
{
    internal class AlarmeClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

        public TimeSpan StopWatchTime { get; set; }

        public bool IsAlarmOn
        {
            get => Settings.IsAlarmOn;
            set => Settings.IsAlarmOn = value;
        }

        public bool IsTimeToAwake()
        {
            if (!IsAlarmOn)
            {
                return false;
            }

            var now = DateTime.Now.TimeOfDay;
            if (now.Hours == Settings.WaitingAlarmTime.Hours
                && now.Minutes == Settings.WaitingAlarmTime.Minutes)
            {
                return true;
            }

            return false;
        }

        public SettingsModel Settings { get; set; } = new SettingsModel();
    }
}
