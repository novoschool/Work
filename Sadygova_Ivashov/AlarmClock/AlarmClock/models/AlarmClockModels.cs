using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.models
{
    public class AlarmClockModels
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

        public SettingsModel Settings { get; set; }
    }
}
