using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZlateKnightF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var mainPen = new Pen(Color.Black, 3);

            g.FillEllipse(Brushes.Red, 650, 300, 600, 600);
            g.FillEllipse(Brushes.Black, 700, 350, 500, 500);
        }
    }
}
