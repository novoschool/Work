using AlarmClock._0._1.Forms1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock._0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
