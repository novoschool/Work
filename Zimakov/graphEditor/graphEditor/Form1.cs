using graphEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphEditor
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private bool _isMouseDown;

        private int _y, _x;

        private RectangelModel _rectangelModel = new RectangelModel
        {
            X = 200,
            Y = 200,
            Width = 200,
            Height = 200
        };

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            //using (var g = CreateGraphics())
            //{
            //    g.DrawRectangle(Pens.Black, e.X - 10, e.Y - 10, 20, 20);
            //}

            //_isMouseDown = true;
            //_x = e.X;
            //_y = e.Y;


            //_rectangelModel.SetDrawMode(e.X, e.Y);
            _rectangelModel.CheckAndSelect(e.X, e.Y);
            Refresh();


        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            //using (var g = CreateGraphics())
            //{
            //    g.FillEllipse(Brushes.Aqua, e.X - 10, e.Y - 10, 20, 20);
            //}

            //_isMouseDown = false;

            _rectangelModel.ResetDrawMode();
            Refresh();
            
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (_rectangelModel.DrawMode)
            {
                g.DrawRectangle(Pens.Black, _rectangelModel.Left, _rectangelModel.Top, Math.Abs(_rectangelModel.Width), Math.Abs(_rectangelModel.Height));
            }
            else
            {
                var pen = new Pen(Color.Gray, 3);
                g.FillRectangle(Brushes.Pink, _rectangelModel.Left, _rectangelModel.Top, Math.Abs(_rectangelModel.Width), Math.Abs(_rectangelModel.Height));
                g.DrawRectangle(pen, _rectangelModel.Left, _rectangelModel.Top, Math.Abs(_rectangelModel.Width), Math.Abs(_rectangelModel.Height));
            }

            if(_rectangelModel.IsSelected)
            {
                g.FillRectangle(Brushes.White, _rectangelModel.Left - 5, _rectangelModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Left - 5, _rectangelModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangelModel.Right - 5, _rectangelModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Right - 5, _rectangelModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangelModel.Left - 5, _rectangelModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Left - 5, _rectangelModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.Black, _rectangelModel.Right - 5, _rectangelModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Right - 5, _rectangelModel.Bottom - 5, 10, 10);


                g.FillRectangle(Brushes.White, (_rectangelModel.Left + _rectangelModel.Right) / 2 - 5, _rectangelModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, (_rectangelModel.Left + _rectangelModel.Right) / 2 - 5, _rectangelModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, (_rectangelModel.Left + _rectangelModel.Right) / 2 - 5, _rectangelModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, (_rectangelModel.Left + _rectangelModel.Right) / 2 - 5, _rectangelModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangelModel.Left - 5, (_rectangelModel.Top + _rectangelModel.Bottom) / 2 - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Left - 5, (_rectangelModel.Top + _rectangelModel.Bottom) / 2 - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangelModel.Right - 5, (_rectangelModel.Top + _rectangelModel.Bottom) / 2 - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangelModel.Right - 5, (_rectangelModel.Top + _rectangelModel.Bottom) / 2 - 5, 10, 10);

            }
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_rectangelModel.DrawMode)
            {
                return;
            }

            //using (var g = CreateGraphics())
            //{
            //    g.DrawLine(Pens.Pink, _x, _y, e.X, e.Y);
            //}

            //using (var g = CreateGraphics())
            //{
            //    g.DrawLine(Pens.Pink, _x, _y, e.X, e.Y);
            //    _x = e.X;
            //    _y = e.Y;
            //}

            //_rectangelModel.Draw(e.X, e.Y);
            Refresh();
        }
    }
}
