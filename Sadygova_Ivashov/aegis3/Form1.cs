using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aegis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var mainPen = new Pen(Color.Black, 1);
            var mainPen3 = new Pen(Color.Black, 2);
            var mainPen2 = new Pen(Color.SaddleBrown, 10);
            var mainPen4 = new Pen(Color.White, 3);

            float scaleFactor = Math.Min(Width / 1000.0f, Height / 1000.0f);
            g.ScaleTransform(scaleFactor, scaleFactor);

            g.FillRectangle(Brushes.Green, 50, 650, 900, 300);
            g.DrawRectangle(mainPen, 50, 650, 900, 300);

            g.DrawEllipse(mainPen2, 400, 350, 150, 150);
            g.FillEllipse(Brushes.Yellow, 50, 50, 150, 150);

            g.FillRectangle(Brushes.Chocolate, 200, 300, 600, 600);
            g.DrawRectangle(mainPen, 200, 300, 600, 600);

            g.FillRectangle(Brushes.SaddleBrown, 425, 600, 150, 300);
            g.DrawRectangle(mainPen, 425, 600, 150, 300);

            g.DrawEllipse(mainPen2, 400, 350, 200, 200);
            g.FillEllipse(Brushes.Aqua, 400, 350, 200, 200);

            g.DrawLine(mainPen4, 400, 450, 600, 450);
            g.DrawLine(mainPen4, 500, 350, 500, 550);

            g.DrawEllipse(mainPen3, 550, 725, 15, 15);
            g.FillEllipse(Brushes.SaddleBrown, 550, 725, 15, 15);

            g.FillRectangle(Brushes.GreenYellow, 870, 800, 10, 40);
            g.DrawRectangle(mainPen, 870, 800, 10, 40);

            g.FillEllipse(Brushes.Blue, 845, 785, 20, 20);
            g.FillEllipse(Brushes.Blue, 885, 785, 20, 20);
            g.FillEllipse(Brushes.Blue, 865, 765, 20, 20);
            g.FillEllipse(Brushes.Blue, 880, 770, 20, 20);
            g.FillEllipse(Brushes.Blue, 850, 770, 20, 20);
            g.FillEllipse(Brushes.Blue, 865, 800, 20, 20);
            g.FillEllipse(Brushes.Blue, 880, 795, 20, 20);
            g.FillEllipse(Brushes.Blue, 850, 795, 20, 20);

            g.DrawEllipse(mainPen3, 860, 780, 30, 30);
            g.FillEllipse(Brushes.Red, 860, 780, 30, 30);

            g.FillRectangle(Brushes.Gray, 300, 100, 50, 150);
            g.DrawRectangle(mainPen, 300, 100, 50, 150);

            g.DrawEllipse(mainPen3, 300, 50, 20, 40);
            g.FillEllipse(Brushes.LightGray, 300, 50, 20, 40);

            g.DrawEllipse(mainPen3, 335, 35, 20, 40);
            g.FillEllipse(Brushes.LightGray, 335, 35, 20, 40);

            g.DrawEllipse(mainPen3, 315, 0, 20, 40);
            g.FillEllipse(Brushes.LightGray, 315, 0, 20, 40);

            Point point1 = new Point(100, 300);
            Point point2 = new Point(200, 100);
            Point point3 = new Point(300, 300);

            int xShift = 50;

            point1.X = (int)((point1.X - xShift) * 3 + xShift);
            point2.X = (int)((point2.X - xShift) * 3 + xShift);
            point3.X = (int)((point3.X - xShift) * 3 + xShift);

            Point[] trianglePoints = { point1, point2, point3 };
            g.FillPolygon(Brushes.SaddleBrown, trianglePoints);


        }
    }
}