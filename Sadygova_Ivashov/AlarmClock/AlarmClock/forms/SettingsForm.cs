using AlarmClock.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock.forms
{
    public partial class SettingsForm : Form
    {
        public SettingsModel Model;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }
    }
}
