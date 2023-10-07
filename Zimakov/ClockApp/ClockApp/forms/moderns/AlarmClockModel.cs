using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp.forms.moderns
{
    internal class AlarmClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;
    }
}
