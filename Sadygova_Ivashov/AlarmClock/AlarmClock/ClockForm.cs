using AlarmClock.forms;
using AlarmClock.models;
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

namespace AlarmClock
{
    public partial class Form_Main : Form
    {
        internal AlarmClockModels model = new AlarmClockModels();

        private string _initialText;

        private AwakeForm _awakeForm;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Model = model.Settings;

            if (settingsForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form1 = new AboutForm())
            {
                form1.ShowDialog();
            }
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            DisplayLabel.Text = model.CurrentTime.ToString(@"hh\:mm\:ss");

            if (model.IsTimeToAwake())
            {
                if (_awakeForm == null || _awakeForm.IsDisposed)
                {
                    _awakeForm = new AwakeForm();
                    _awakeForm.Model = model.Settings;
                }
                _awakeForm.Show();

                if (model.Settings.IsSoundOn)
                {
                    SystemSounds.Beep.Play();
                }
            }
        }
    }
}
