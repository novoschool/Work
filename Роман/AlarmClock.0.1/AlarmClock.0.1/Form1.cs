using AlarmClock._0._1.Forms1;
using AlarmClock._0._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock._0._1
{
    public partial class Form1 : Form
    {
        private ClockModel _model = new ClockModel();

        private string _initialText;

        private AwakeForm _awakeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (_model.IsTimeToAwake())
            {
                if (_awakeForm == null || _awakeForm.IsDisposed)
                {
                    _awakeForm = new AwakeForm();
                    _awakeForm.Model = _model.Settings;
                }

                _awakeForm.Show();

                if (_model.Settings.IsSoundOn)
                {
                    SystemSounds.Beep.Play();
                }
            }

            ClockLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
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
    }
}
