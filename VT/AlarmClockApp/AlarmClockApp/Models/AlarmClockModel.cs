using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    internal class AlarmClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;
    }
}
