using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.models
{
    internal class AlarmClockModels
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;
    }
}
