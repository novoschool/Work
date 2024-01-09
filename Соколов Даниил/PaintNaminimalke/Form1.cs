using PaintNaminimalke.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintNaminimalke
{
    public partial class Form1 : Form
    {
        private bool _isMouseDawn;

        private int _x;

        private int _y;

        public Form1()
        {
            InitializeComponent();
        }

        private RectangleModel _rectangleModel = new RectangleModel
        {
            X = 300,
            Y = 300,
            Width = 50,
            Height = 50,
        };

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left )
            {
                return;
            }


            _rectangleModel.CheckAndSelect(e.X, e.Y);
            //_rectangleModel.SetDrawMode(e.X, e.Y);
            Refresh();
        }
        
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _rectangleModel.ResetDrawMode();
            Refresh();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_rectangleModel.DrawMode)
            {
                return;
            }

            _rectangleModel.Draw(e.X, e.Y);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
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
                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, _rectangleModel.Top - 5, 10 , 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Right - 5, _rectangleModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, _rectangleModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.Black, _rectangleModel.Right - 5, _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, _rectangleModel.Bottom - 5, 10, 10);


                g.FillRectangle(Brushes.White, (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, _rectangleModel.Top - 5, 10, 10);
                g.DrawRectangle(Pens.Black, (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, _rectangleModel.Top - 5, 10, 10);

                g.FillRectangle(Brushes.White, (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, _rectangleModel.Bottom - 5, 10, 10);
                g.DrawRectangle(Pens.Black, (_rectangleModel.Left + _rectangleModel.Right) / 2 - 5, _rectangleModel.Bottom - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Left - 5, (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5 , 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Left - 5, (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);

                g.FillRectangle(Brushes.White, _rectangleModel.Right - 5, (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);
                g.DrawRectangle(Pens.Black, _rectangleModel.Right - 5, (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - 5, 10, 10);
            }
        }
    }
}
