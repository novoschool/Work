using MultipleRectangleEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleRectangleEditor
{
    public partial class GraphEditorForm : Form
    {
        private RectangleCollectionModel _model = new RectangleCollectionModel();

        private bool _addNewRectangleMode = false;

        public GraphEditorForm()
        {
            InitializeComponent();
        }

        private void GraphEditorForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (_addNewRectangleMode)
            {
                _model.AddNewRectangle(e.X, e.Y);
            }

            Refresh();
        }

        private void GraphEditorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_model.SelectedRectangle != null && _model.SelectedRectangle.IsAction)
            {
                _model.SelectedRectangle.DoAction(e.X, e.Y);
                Refresh();
            }
        }

        private void GraphEditorForm_MouseUp(object sender, MouseEventArgs e)
        {
            _model.CheckForSize();

            if (_model.SelectedRectangle != null && _model.SelectedRectangle.IsAction)
            {
                _model.SelectedRectangle.ResetMode();
            }

            Refresh();
        }

        private void GraphEditorForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            foreach (var r in _model.Rectangles)
            {
                if (r.IsAction)
                {
                    g.DrawRectangle(Pens.Black, r.Left, r.Top,
                        Math.Abs(r.Width), Math.Abs(r.Height));
                }
                else
                {
                    var pen = new Pen(Color.Blue, 3);
                    g.FillRectangle(Brushes.Yellow, r.Left, r.Top,
                        Math.Abs(r.Width), Math.Abs(r.Height));
                    g.DrawRectangle(pen, r.Left, r.Top,
                        Math.Abs(r.Width), Math.Abs(r.Height));
                }

                if (r.IsSelected)
                {
                    g.FillRectangle(Brushes.White,
                        r.Left - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Left - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        r.Right - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Right - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        r.Left - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Left - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.Black,
                        r.Right - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Right - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        (r.Left + r.Right) / 2 - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        (r.Left + r.Right) / 2 - r.MarkerHalfWidth,
                        r.Top - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        (r.Left + r.Right) / 2 - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        (r.Left + r.Right) / 2 - r.MarkerHalfWidth,
                        r.Bottom - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        r.Left - r.MarkerHalfWidth,
                        (r.Top + r.Bottom) / 2 - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Left - r.MarkerHalfWidth,
                        (r.Top + r.Bottom) / 2 - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);

                    g.FillRectangle(Brushes.White,
                        r.Right - r.MarkerHalfWidth,
                        (r.Top + r.Bottom) / 2 - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                    g.DrawRectangle(Pens.Black,
                        r.Right - r.MarkerHalfWidth,
                        (r.Top + r.Bottom) / 2 - r.MarkerHalfHeight,
                        r.MarkerHalfWidth * 2, r.MarkerHalfHeight * 2);
                }
            }
        }

        private void AddRectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            _addNewRectangleMode = ((ToolStripButton)sender).Checked;
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
