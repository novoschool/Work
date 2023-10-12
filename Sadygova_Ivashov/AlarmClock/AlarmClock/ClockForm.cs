using AlarmClock.forms;
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

namespace AlarmClock
{
    public partial class Form_Main : Form
    {
        internal AlarmClockModels model = new AlarmClockModels();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = model.CurrentTime.ToString(@"hh\:mm\:ss");
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
    }
}
