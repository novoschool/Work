using AlarmeClock2.Forms;
using AlarmeClock2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private AwakeForm AwakeForm;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DislayLable.Text = Model.CurrentTime.ToString(@"hh\:mm\:ss");

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

        private void TimerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
