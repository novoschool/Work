﻿using ClockApp.forms;
using ClockApp.forms.moderns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class ClockApp : Form
    {
        internal AlarmClockModel Model = new AlarmClockModel();

        private AwakeForm _awakeForm;


        public ClockApp()
        {
            InitializeComponent();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = Model.CurrentTime.ToString(@"hh\:mm\:ss");
            displayTime.Text = Model.ShiftedTime.ToString(@"hh\:mm\:ss");

            if (Model.IsTimeToAwake())
            {
                if (_awakeForm == null || _awakeForm.IsDisposed)
                {
                    _awakeForm = new AwakeForm();
                    _awakeForm.Model = Model.Settings;
                }

                _awakeForm.Show();
                CheckAlarmActive.BackColor= Color.Pink;

                if (Model.IsSoundOn)
                {
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void timeMSKbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = -4;
            timeKGDbutton.BackColor = Color.MistyRose;
            timeEKBbutton.BackColor = Color.MistyRose;
            timeMSKbutton.BackColor = Color.Coral;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (stopButton.Text == "Stop")
            {
                clockTimer.Stop();
                stopButton.Text = "Start";
            } else
            {
                clockTimer.Start();
                stopButton.Text = "Stop";
            }
        }

        private void infoProgramm_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new aboutForm()) {
                aboutForm.ShowDialog();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var SettingsForm = new settingsForm();
            SettingsForm.Model = Model.Settings;

            if (SettingsForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            DisplayAlarmMode();
        }

        private void DisplayAlarmMode()
        {
            if(Model.Settings.IsAlarmOn)
            {
                CheckAlarmActive.Visible = true;
            }
            else
            {
                CheckAlarmActive.Visible = false;
            }
        }

        private void timeEKBbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = -2;
            timeKGDbutton.BackColor = Color.MistyRose;
            timeEKBbutton.BackColor = Color.Coral;
            timeMSKbutton.BackColor = Color.MistyRose;
            timeSAMbutton.BackColor = Color.MistyRose;
            timeOMSbutton.BackColor = Color.MistyRose;
            timeIRKbutton.BackColor = Color.MistyRose;

        }

        private void timeKGDbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = -5;
            timeKGDbutton.BackColor = Color.Coral;
            timeEKBbutton.BackColor = Color.MistyRose;
            timeMSKbutton.BackColor = Color.MistyRose;
            timeSAMbutton.BackColor = Color.MistyRose;
            timeOMSbutton.BackColor = Color.MistyRose;
            timeIRKbutton.BackColor = Color.MistyRose;
        }

        private void timeSAMbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = -3;
            timeKGDbutton.BackColor = Color.MistyRose;
            timeEKBbutton.BackColor = Color.MistyRose;
            timeMSKbutton.BackColor = Color.MistyRose;
            timeSAMbutton.BackColor = Color.Coral;
            timeOMSbutton.BackColor = Color.MistyRose;
            timeIRKbutton.BackColor = Color.MistyRose;
        }

        private void timeOMSbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = -1;
            timeKGDbutton.BackColor = Color.MistyRose;
            timeEKBbutton.BackColor = Color.MistyRose;
            timeMSKbutton.BackColor = Color.MistyRose;
            timeSAMbutton.BackColor = Color.MistyRose;
            timeOMSbutton.BackColor = Color.Coral;
            timeIRKbutton.BackColor = Color.MistyRose;
        }

        private void timeIRKbutton_Click(object sender, EventArgs e)
        {
            Model.TimeShiftHours = 1;
            timeKGDbutton.BackColor = Color.MistyRose;
            timeEKBbutton.BackColor = Color.MistyRose;
            timeMSKbutton.BackColor = Color.MistyRose;
            timeSAMbutton.BackColor = Color.MistyRose;
            timeOMSbutton.BackColor = Color.MistyRose;
            timeIRKbutton.BackColor = Color.Coral;
        }
    }
}
