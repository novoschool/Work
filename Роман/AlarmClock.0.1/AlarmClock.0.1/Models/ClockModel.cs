﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock._0._1.Models
{
    public class ClockModel
    {
        public TimeSpan CurrentTime => DateTime.Now.TimeOfDay;

        public bool IsAlarmOn
        {
            get => Settings.IsAlarmOn;
            set => Settings.IsAlarmOn = value;
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
