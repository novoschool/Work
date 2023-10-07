using AlarmeClock2.Forms;
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

namespace AlarmeClock2
{
    public partial class ClockForm : Form
    {
        internal AlarmeClockModel Model = new AlarmeClockModel();

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
            {
                DislayLable.Text = Model.CurrentTime.ToString(@"hh\:mm\:ss");
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

        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void DislayLable_Click(object sender, EventArgs e)
        {

        }
    }
}
