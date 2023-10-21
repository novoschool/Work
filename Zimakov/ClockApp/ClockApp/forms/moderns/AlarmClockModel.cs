using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.forms.moderns
{
    public class AlarmClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

        public TimeSpan ShiftedTime => DateTime.Now.TimeOfDay + new TimeSpan(TimeShiftHours, 0, 0);
    
        

        public SettingModel Settings { get; set; } = new SettingModel();

        public int TimeShiftHours { get; set; } = 0;

        public bool IsAlarmOn
        {
            get => Settings.IsAlarmOn;
            set => Settings.IsAlarmOn = value;
        }
        public bool IsSoundOn
        {
            get => Settings.IsSoundOn;
            set => Settings.IsSoundOn = value;
        }

        public bool IsTimeToAwake()
        {
            if (!IsAlarmOn)
            {
                return false;
            }
            var now = DateTime.Now.TimeOfDay;
            if (now.Hours == Settings.AlarmTime.Hours && now.Minutes == Settings.AlarmTime.Minutes)
            {
                return true;
            }
            return false;
        }
    }
}