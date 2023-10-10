using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.forms.moderns
{
    public class SettingModel
    {
        public TimeSpan AlarmTime { get; set; } = DateTime.Now.TimeOfDay;

        public string AlarmMessage { get; set; } = string.Empty;

        public bool IsAlarmOn { get; set; }

        public bool IsSoundOn { get; set; }
    }
}
