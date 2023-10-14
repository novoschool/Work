using AlarmeClock2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmeClock2.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsModel Model { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Model == null)
            {
                return;
            }

            AlarmTimeTextBox.Text = Model.AlarmTime.ToString(@"hh\:mm");
            MessageTextBox.Text = Model.AlarmMessage;
            AlarmCheckBox.Checked = Model.IsAlarmOn;
            SoundCheckBox.Checked = Model.IsSoundOn;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(AlarmTimeTextBox.Text, out var alarmTime))
            {
                Model.AlarmTime = alarmTime;
            }
            else
            {
                MessageBox.Show("Введено неверное время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AlarmTimeTextBox.Focus();
                AlarmTimeTextBox.SelectAll();
                return;
            }

            Model.AlarmMessage = MessageTextBox.Text;
            Model.IsAlarmOn = AlarmCheckBox.Checked;
            Model.IsSoundOn = SoundCheckBox.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
