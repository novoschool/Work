using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.models
{
    public class SettingsModel
    {
        public TimeSpan AlarmTime { get; set; } = DateTime.Now.TimeOfDay;

        public string AlarmMessage { get; set; } = String.Empty;

        public bool IsAlarmOn { get; set; }

        public bool IsSoundOn { get; set;}

        public SettingsModel Settings { get; set; }
    }
}
