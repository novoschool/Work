using MouseEvents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvents
{
    public partial class MouseEventsForm : Form
    {
        private bool _isMouseDown;

        private int _x;

        private int _y;

        private RectangleModel _rectangleModel = new RectangleModel
        {
            X = 100,
            Y = 100,
            Width = 500,
            Height = 300,
        };

        public MouseEventsForm()
        {
            InitializeComponent();
        }

        // 1. Discrete events
        //private void MouseEventsForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    using (var g = CreateGraphics())
        //    {
        //        g.DrawRectangle(Pens.Black, e.X - 10, e.Y - 10, 20, 20);
        //    }

        //    _isMouseDown = true;
        //}

        //private void MouseEventsForm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    using (var g = CreateGraphics())
        //    {
        //        g.DrawEllipse(Pens.Black, e.X - 10, e.Y - 10, 20, 20);
        //    }

        //    _isMouseDown = false;
        //}

        //private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!_isMouseDown)
        //    {
        //        return;
        //    }

        //    using (var g = CreateGraphics())
        //    {
        //        g.DrawLine(Pens.Black, e.X - 10, e.Y, e.X + 10, e.Y);
        //        g.DrawLine(Pens.Black, e.X, e.Y - 10, e.X, e.Y + 10);
        //    }
        //}

        // 2. Fan
        //private void MouseEventsForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _isMouseDown = true;
        //    _x = e.X;
        //    _y = e.Y;
        //}

        //private void MouseEventsForm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _isMouseDown = false;
        //}

        //private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!_isMouseDown)
        //    {
        //        return;
        //    }

        //    using (var g = CreateGraphics())
        //    {
        //        g.DrawLine(Pens.Black, _x, _y, e.X, e.Y);
        //    }
        //}

        // 3. Curve
        //private void MouseEventsForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _isMouseDown = true;
        //    _x = e.X;
        //    _y = e.Y;
        //}

        //private void MouseEventsForm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _isMouseDown = false;
        //}

        //private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!_isMouseDown)
        //    {
        //        return;
        //    }

        //    using (var g = CreateGraphics())
        //    {
        //        g.DrawLine(Pens.Black, _x, _y, e.X, e.Y);
        //        _x = e.X;
        //        _y = e.Y;
        //    }
        //}

        // 4. Rectangle creation
        //private void MouseEventsForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _rectangleModel.SetDrawMode(e.X, e.Y);
        //    Refresh();
        //}

        //private void MouseEventsForm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //    {
        //        return;
        //    }

        //    _rectangleModel.ResetDrawMode();
        //    Refresh();
        //}

        //private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!_rectangleModel.DrawMode)
        //    {
        //        return;
        //    }

        //    _rectangleModel.Draw(e.X, e.Y);
        //    Refresh();
        //}

        //private void MouseEventsForm_Paint(object sender, PaintEventArgs e)
        //{
        //    var g = e.Graphics;
        //    if (_rectangleModel.DrawMode)
        //    {
        //        g.DrawRectangle(Pens.Black, _rectangleModel.Left, _rectangleModel.Top,
        //            Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
        //    }
        //    else
        //    {
        //        var pen = new Pen(Color.Blue, 3);
        //        g.FillRectangle(Brushes.Yellow, _rectangleModel.Left, _rectangleModel.Top,
        //            Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
        //        g.DrawRectangle(pen, _rectangleModel.Left, _rectangleModel.Top,
        //            Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
        //    }
        //}

        // 5. Rectangle selection
        private void MouseEventsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _rectangleModel.CheckAndSelect(e.X, e.Y);
            Refresh();
        }

        private void MouseEventsForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
        }

        private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_rectangleModel.DrawMode)
            {
                return;
            }
        }

        private void MouseEventsForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (_rectangleModel.DrawMode)
            {
                g.DrawRectangle(Pens.Black, _rectangleModel.Left, _rectangleModel.Top,
                    Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
            }
            else
            {
                var pen = new Pen(Color.Blue, 3);
                g.FillRectangle(Brushes.Yellow, _rectangleModel.Left, _rectangleModel.Top,
                    Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
                g.DrawRectangle(pen, _rectangleModel.Left, _rectangleModel.Top,
                    Math.Abs(_rectangleModel.Width), Math.Abs(_rectangleModel.Height));
            }

            if (_rectangleModel.IsSelected)
            {
                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, 
                    _rectangleModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, 
                    _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Right - 5, 
                    _rectangleModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, 
                    _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.Black, _rectangleModel.Right - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.White, 
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, 
                    _rectangleModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, 
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, 
                    _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, 
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, 
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, 
                    _rectangleModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, 
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, 
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Right - 5, 
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, 
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);
            }
        }
    }
}
