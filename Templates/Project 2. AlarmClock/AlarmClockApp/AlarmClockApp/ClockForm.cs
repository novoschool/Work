using AlarmClockApp.Forms;
using AlarmClockApp.Models;
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

namespace AlarmClockApp
{
    public partial class ClockForm : Form
    {
        private ClockModel _model = new ClockModel();

        private string _initialText;

        private AwakeForm _awakeForm;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsFrom = new SettingsForm();
            settingsFrom.Model = _model.Settings;

            if (settingsFrom.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            DisplayAlarmMode();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DisplayLabel.Text = _model.CurrentTime.ToString(@"hh\:mm\:ss");

            if (_model.IsTimeToAwake())
            {
                if (_awakeForm == null || _awakeForm.IsDisposed)
                {
                    _awakeForm = new AwakeForm();
                    _awakeForm.Model = _model.Settings;
                }

                _awakeForm.Show();

                if (_model.IsSoundOn)
                {
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            _initialText = Text;
            _model.Settings.AlarmOff = () => DisplayAlarmMode();
        }

        private void DisplayAlarmMode()
        {
            if (_model.IsAlarmOn)
            {
                Text = _initialText + " (ожидание)";
            }
            else
            {
                Text = _initialText;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _model.IsAlarmOn = false;
            DisplayAlarmMode();
        }
    }
}
