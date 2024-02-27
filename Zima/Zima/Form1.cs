using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zima
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
            var BluePen = new Pen(Color.DarkBlue, 15);
            var BlackPen = new Pen(Color.Black, 15);
            var RedPen = new Pen(Color.DarkRed, 15);
            var YellowPen = new Pen(Color.Yellow, 15);
            var GreenPen = new Pen(Color.DarkGreen, 15);
            g.DrawEllipse(BluePen, 200, 150, 200, 200);

            //g.FillEllipse(Brushes.DarkGray, 320, 250, 200, 200);

            g.DrawEllipse(BlackPen, 440, 150, 200, 200);
            g.DrawEllipse(YellowPen, 320, 250, 200, 200);
            g.DrawEllipse(RedPen, 680, 150, 200, 200);
            g.DrawEllipse(GreenPen, 560, 250, 200, 200);


            g.FillRectangle(Brushes.DarkBlue, 392, 240, 16, 23);


            g.FillRectangle(Brushes.Black, 512, 341, 17, 14);
            g.FillRectangle(Brushes.Black, 519, 344, 11, 14);
            g.FillRectangle(Brushes.Black, 516, 343, 11, 14);
            g.FillRectangle(Brushes.Black, 514, 342, 11, 14);
            g.FillRectangle(Brushes.Black, 512, 339, 8, 14);
            g.FillRectangle(Brushes.Black, 513, 340, 11, 14);

            g.FillRectangle(Brushes.Black, 552, 341, 17, 14);
            g.FillRectangle(Brushes.Black, 562, 339, 10, 14);
            g.FillRectangle(Brushes.Black, 559, 340, 10, 14);
            g.FillRectangle(Brushes.Black, 552, 343, 10, 14);
            g.FillRectangle(Brushes.Black, 552, 342, 14, 14);

            g.FillRectangle(Brushes.DarkRed, 752, 341, 17, 14);
            g.FillRectangle(Brushes.DarkRed, 759, 344, 11, 14);
            g.FillRectangle(Brushes.DarkRed, 756, 343, 11, 14);
            g.FillRectangle(Brushes.DarkRed, 754, 342, 11, 14);
            g.FillRectangle(Brushes.DarkRed, 752, 339, 8, 14);
            g.FillRectangle(Brushes.DarkRed, 753, 340, 11, 14);
        }
    }
}
