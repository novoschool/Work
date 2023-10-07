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
    }
}
