using AlarmClockApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockApp.Forms
{
    public partial class AwakeForm : Form
    {
        public SettingsModel Model { get; set; }

        public AwakeForm()
        {
            InitializeComponent();
        }

        private void AwakeButton_Click(object sender, EventArgs e)
        {
            Model.IsAlarmOn = false;
            Close();
        }

        private void AwakeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
