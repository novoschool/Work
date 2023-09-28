using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aegis2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawRectangles(e.Graphics);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawRectangles(Graphics g)
        {
            var mainPen = new Pen(Color.Black, 1);

            float x = 100 * Width / 800; 
            float y = 100 * Height / 600;
            float width = 150 * Width / 800;
            float height = 300 * Height / 600;

            g.FillRectangle(Brushes.Green, x, y, width, height);
            g.DrawRectangle(mainPen, x, y, width, height);

            x = 250 * Width / 800;

            g.FillRectangle(Brushes.White, x, y, width, height);
            g.DrawRectangle(mainPen, x, y, width, height);

            x = 400 * Width / 800;

            g.FillRectangle(Brushes.Red, x, y, width, height);
            g.DrawRectangle(mainPen, x, y, width, height);
        }
    }
}