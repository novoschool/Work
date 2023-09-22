using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Роман
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

            g.FillRectangle(Brushes.DarkGray, 50, 100, 200, 300);
            g.DrawRectangle(mainPen, 50, 100, 200, 300);

            g.FillRectangle(Brushes.DarkGray, 250, 300, 400, 100);
            g.DrawRectangle(mainPen, 250, 300, 400, 100);

            g.FillRectangle(Brushes.DarkGray, 500, 100, 200, 300);
            g.DrawRectangle(mainPen, 500, 100, 200, 300);

            g.FillRectangle(Brushes.DarkGray, 580, 150, 50, 50);
            g.DrawRectangle(mainPen, 580, 150, 50, 50);

            g.FillRectangle(Brushes.DarkGray, 580, 300, 50, 50);
            g.DrawRectangle(mainPen, 580, 300, 50, 50);

            g.FillRectangle(Brushes.DarkGray, 120, 150, 50, 50);
            g.DrawRectangle(mainPen, 120, 150, 50, 50);

            g.FillRectangle(Brushes.DarkGray, 120, 300, 50, 50);
            g.DrawRectangle(mainPen, 120, 300, 50, 50);

            g.FillPie(Brushes.DarkGray, 320, 20, 150, 150, 250, 400);
            g.DrawArc(mainPen, 320, 20, 150, 150, 250, 400);

            g.FillPie(Brushes.DarkGray, 50, 20, 250, 70, 250, 400);
            g.DrawArc(mainPen, 50, 20, 250, 70, 250, 400);

            g.FillPie(Brushes.DarkGray, 500, 20, 250, 70, 250, 400);
            g.DrawArc(mainPen, 500, 20, 250, 70, 250, 400);

            var points = new[]
            {
                new Point(350, 300),
                new Point(380, 300),
                new Point(400, 250),
                new Point(500, 300),
            };
            g.FillPolygon(Brushes.DarkGray, points);
            g.DrawPolygon(mainPen, points);
        }
    }
}
