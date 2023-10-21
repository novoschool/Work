using AlarmeClock2.Forms;
using AlarmeClock2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmeClock2
{
    public partial class ClockForm : Form
    {
        internal AlarmeClockModel Model = new AlarmeClockModel();

        internal bool StopwatchOn = false;
        internal bool StopwatchStop = true;

        private AwakeForm AwakeForm;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DislayLable.Text = Model.CurrentTime.ToString(@"hh\:mm\:ss");
            TimerLabel.Text = Model.StopWatchTime.ToString(@"hh\:mm\:ss");

            if (StopwatchOn && StopwatchStop)
            {
                Model.StopWatchTime = Model.StopWatchTime + new TimeSpan(0, 0, 1);
                TimerLabel.ForeColor = Color.Aqua;
            }
            else
            {
                TimerLabel.ForeColor = Color.OrangeRed;
            }

            if (Model.IsTimeToAwake())
            {
                if (AwakeForm == null || AwakeForm.IsDisposed)
                {
                    AwakeForm = new AwakeForm() { Model = Model.Settings };
                }

                AwakeForm.Show();

                //if (Model.IsSoundOn)
                //{
                //    SystemSounds.Question.Play();
                //}
            }

            
            
        }

        private void AbautButton_Click(object sender, EventArgs e)
        {
            using (var aboutForms = new AbautForms()) 
            {
                aboutForms.ShowDialog();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Model = Model.Settings;
            if (settingsForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //DisplayAlarmMode();
        }

        private void TimerButtonOn_Click(object sender, EventArgs e)
        {
            Model.StopWatchTime = new TimeSpan(0, 0, 0);
            StopwatchOn = !StopwatchOn;
        }

        private void TimerButtonStop_Click(object sender, EventArgs e)
        {
            StopwatchStop = !StopwatchStop;
            //TimerButtonStop.Enabled =StopwatchStop;
        }

    }
}
