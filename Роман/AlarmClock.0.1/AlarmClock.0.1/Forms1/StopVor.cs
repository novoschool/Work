using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock._0._1.Forms1
{
    public partial class StopVor : Form
    {
        int start;

        public StopVor()
        {
            InitializeComponent();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            start = 0;
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            start++;
            Start.Text = start.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = !timer1.Enabled;
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
