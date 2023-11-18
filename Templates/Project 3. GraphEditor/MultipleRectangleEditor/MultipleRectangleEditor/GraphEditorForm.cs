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
            else
            {
                _model.CheckAndSelect(e.X, e.Y);

                if (_model.SelectedRectangle != null)
                {
                    _model.SelectedRectangle.SetActionMode(e.X, e.Y);
                }
            }

            Refresh();
        }

        private void GraphEditorForm_MouseMove(object sender, MouseEventArgs e)
        {
            switch (_model.GetPossibleAction(e.X, e.Y))
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
            }

            var selectedRectangle = _model.SelectedRectangle;
            if (selectedRectangle != null)
            {
                g.FillRectangle(Brushes.White,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.Black,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    (selectedRectangle.Left + selectedRectangle.Right) / 2 - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    (selectedRectangle.Left + selectedRectangle.Right) / 2 - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Top - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    (selectedRectangle.Left + selectedRectangle.Right) / 2 - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    (selectedRectangle.Left + selectedRectangle.Right) / 2 - selectedRectangle.MarkerHalfWidth,
                    selectedRectangle.Bottom - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    (selectedRectangle.Top + selectedRectangle.Bottom) / 2 - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Left - selectedRectangle.MarkerHalfWidth,
                    (selectedRectangle.Top + selectedRectangle.Bottom) / 2 - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);

                g.FillRectangle(Brushes.White,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    (selectedRectangle.Top + selectedRectangle.Bottom) / 2 - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
                g.DrawRectangle(Pens.Black,
                    selectedRectangle.Right - selectedRectangle.MarkerHalfWidth,
                    (selectedRectangle.Top + selectedRectangle.Bottom) / 2 - selectedRectangle.MarkerHalfHeight,
                    selectedRectangle.MarkerHalfWidth * 2, selectedRectangle.MarkerHalfHeight * 2);
            }
        }

        private void AddRectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            _addNewRectangleMode = ((ToolStripButton)sender).Checked;
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            _model.RemoveSelected();
            Refresh();
        }
    }
}
