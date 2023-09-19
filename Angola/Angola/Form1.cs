using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            var clientRectangle = ClientRectangle;
            var Hight = clientRectangle.Height;
            var Width = clientRectangle.Width;

            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, Width, Height/2);
            g.FillRectangle(new SolidBrush(Color.Black), 0, Hight/2, Width, Height / 2);

            Star((Width/12) * 5, ((Hight/18) * 6), Width/10, Hight/7);


            
        }

        void Star(int X, int Y, int Width, int Hight)
        {
            var g = CreateGraphics();

            Point[] points1 = new Point[3];
            points1[0] = new Point(X + (Width/2), Y);
            points1[1] = new Point(X + (Width/6), Y + Hight);
            points1[2] = new Point(X + ((Width/6)*4), Y + ((Hight/10)*6));
            g.FillPolygon(new SolidBrush(Color.Yellow), points1);

            Point[] points2 = new Point[3];
            points2[0] = new Point(X + (Width / 2), Y);
            points2[1] = new Point(X + (Width / 6)*5, Y + Hight);
            points2[2] = new Point(X + (Width / 6)*2, Y + ((Hight / 10) * 6));
            g.FillPolygon(new SolidBrush(Color.Yellow), points2);

            Point[] points3 = new Point[3];
            points3[0] = new Point(X, Y + (Hight/10)*4);
            points3[1] = new Point(X + Width, Y + (Hight/10) * 4);
            points3[2] = new Point(X + Width/2, Y + ((Hight/7) * 5));
            g.FillPolygon(new SolidBrush(Color.Yellow), points3);
        }
    }
}
