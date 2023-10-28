using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework12
{
    public partial class Form1 : Form
    {
        private bool _isMouseDown;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            using (var g = CreateGraphics())
            {
                g.DrawRectangle(Pens.Black, e.X - 10, e.Y - 10, 20, 20);
            }

            _isMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            using (var g = CreateGraphics())
            {
                g.DrawEllipse(Pens.Black, e.X - 10, e.Y - 10, 20, 20);
            }

            _isMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown)
            {
                return;
            }

            using (var g = CreateGraphics())
            {
                g.DrawLine(Pens.Black, e.X - 10, e.Y, e.X + 10, e.Y);
                g.DrawLine(Pens.Black, e.X, e.Y - 10, e.X, e.Y + 10);
            }
        }

        // 2. Beep
        //private void MouseEventeForm_MouseDown(object sender, MouseEventArgs e)
        //{

        private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown)
            {
                return;
            }

            using (var g = CreateGraphics())
            {
                g.DrawLine(Pens.Black, _x, _y, e.X, e.Y);
                _x = e.X;
                _y = e.Y;
            }
        }
    }
    
}
