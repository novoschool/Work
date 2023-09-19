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
            var Black = new Pen(Color.Black);
            var clientRectangle = ClientRectangle;
            var Hight = clientRectangle.Height;
            var Width = clientRectangle.Width;

            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, Width, Height/2);
            g.FillRectangle(new SolidBrush(Color.Black), 0, Hight/2, Width, Height / 2);

            Star((Width/12) * 5, (Height/14) * 5, Width/10, Hight/7);


            
        }

        void Star(int X, int Y, int Width, int Hight)
        {


            Point[] points1 = new Point[3];
            points1[0] = new Point(X + (Width/2), Y);
            points1[1] = new Point(X + (Width/6), Y + Hight);
            points1[2] = new Point(X + ((Width/6)*4), Y + ((Hight/10)*6));
            g.FillPolygon(new SolidBrush(Color.Black), points1);
        }
    }
}
