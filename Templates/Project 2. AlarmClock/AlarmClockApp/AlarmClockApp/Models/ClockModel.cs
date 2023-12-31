﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    public class ClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

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
            if (now.Hours == Settings.AlarmTime.Hours
                && now.Minutes == Settings.AlarmTime.Minutes)
            {
                return true;
            }

            return false;
        }

        public SettingsModel Settings { get; set; } = new SettingsModel();
    }
}
