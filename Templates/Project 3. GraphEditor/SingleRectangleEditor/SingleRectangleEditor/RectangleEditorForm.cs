using SingleRectangleEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleRectangleEditor
{
    public partial class RectangleEditorForm : Form
    {
        private RectangleModel _rectangleModel = new RectangleModel
        {
            X = 100,
            Y = 100,
            Width = 500,
            Height = 300,
        };

        public RectangleEditorForm()
        {
            InitializeComponent();
        }

        private void RectangleEditorForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _rectangleModel.CheckAndSelect(e.X, e.Y);
            if (_rectangleModel.IsSelected)
            {
                _rectangleModel.SetActionMode(e.X, e.Y);
            }
            else
            {
                _rectangleModel.SetDrawMode(e.X, e.Y);
            }

            Refresh();
        }

        private void RectangleEditorForm_MouseMove(object sender, MouseEventArgs e)
        {
            switch (_rectangleModel.PossibleAction(e.X, e.Y))
            {
                case PossibleAction.Select:
                    Cursor = Cursors.Hand;
                    break;
                case PossibleAction.Move:
                    Cursor = Cursors.SizeAll;
                    break;
                case PossibleAction.ResizeBottomRight:
                    Cursor = Cursors.SizeNWSE;
                    break;
                default:
                    Cursor = Cursors.Default;
                    break;
            }

            if (!_rectangleModel.IsAction)
            {
                return;
            }

            _rectangleModel.DoAction(e.X, e.Y);
            Refresh();
        }

        private void RectangleEditorForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _rectangleModel.ResetMode();
            Refresh();
        }

        private void RectangleEditorForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (_rectangleModel.IsAction)
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
                g.FillRectangle(Brushes.White,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.Black,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Top - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    (_rectangleModel.Left + _rectangleModel.Right) / 2 - _rectangleModel.MarkerHalfWidth,
                    _rectangleModel.Bottom - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Left - _rectangleModel.MarkerHalfWidth,
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    _rectangleModel.Right - _rectangleModel.MarkerHalfWidth,
                    (_rectangleModel.Top + _rectangleModel.Bottom) / 2 - _rectangleModel.MarkerHalfHeight,
                    _rectangleModel.MarkerHalfWidth * 2, _rectangleModel.MarkerHalfHeight * 2);
            }
        }
    }
}
