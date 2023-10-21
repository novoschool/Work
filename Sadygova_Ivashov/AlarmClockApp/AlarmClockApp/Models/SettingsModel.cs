using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    public class SettingsModel
    {
        public TimeSpan AlarmTime { get; set; } = DateTime.Now.TimeOfDay;

        public TimeSpan AwakeTime { get; set;} = DateTime.Now.TimeOfDay;

        public string AlarmMessage { get; set; } = string.Empty;

        public bool IsAlarmOn { get; set; }

        public bool IsSoundOn { get; set; }

        public Action AlarmOff { get; set; }
    }
}
