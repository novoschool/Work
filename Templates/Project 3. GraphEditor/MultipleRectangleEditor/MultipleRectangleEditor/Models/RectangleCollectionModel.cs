using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleRectangleEditor.Models
{
    internal class RectangleCollectionModel
    {
        public List<RectangleModel> Rectangles { get; } = new List<RectangleModel>();

        public RectangleModel SelectedRectangle { get; private set; }

        public int SelectedIndex { get; private set; }

        public void AddNewRectangle(int x, int y)
        {
            var newRectangle = new RectangleModel();
            Rectangles.Add(newRectangle);
            newRectangle.SetDrawMode(x, y);
            Select(Rectangles.Count - 1);
        }

        public void Select(int index)
        {
            if (SelectedIndex >= 0)
            {
                Rectangles[SelectedIndex].Deselect();
                SelectedIndex = -1;
                SelectedRectangle = null;
            }

            if (index < 0)
            {
                return;
            }

            var rect = Rectangles[index];
            rect.Select();
            SelectedRectangle = rect;
            SelectedIndex = index;
        }

        public void CheckForSize()
        {
            if (SelectedRectangle != null && SelectedRectangle.ActionMode == FigureActionMode.Drawing)
            {
                if (SelectedRectangle.Width < RectangleModel.MinWidth && SelectedRectangle.Height < RectangleModel.MinHeight)
                {
                    Select(-1);
                    Rectangles.RemoveAt(Rectangles.Count - 1);
                }
            }
        }
    }
}
