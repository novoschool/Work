using ClockApp.forms.moderns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp.forms
{
    public partial class settingsForm : Form
    {
        public SettingModel Model { get; set; }
        public settingsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void settingsForm_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(AlarmTimeTextBox.Text, out var AlarmTime))
            {
                Model.AlarmTime = AlarmTime;
            }
            else
            {
                MessageBox.Show("ti lohped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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