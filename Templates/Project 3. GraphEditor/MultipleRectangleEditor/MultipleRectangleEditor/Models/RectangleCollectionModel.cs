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

        public int SelectedIndex { get; private set; } = -1;

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

        public void CheckAndSelect(int x, int y)
        {
            if (SelectedIndex >= 0 && SelectedRectangle.PossibleAction(x, y) != PossibleAction.None)
            {
                return;
            }

            int index = Rectangles.Count - 1;
            while (index >= 0)
            {
                if (Rectangles[index].IsPointInside(x, y))
                {
                    break;
                }

                index--;
            }

            Select(index);
        }

        public PossibleAction GetPossibleAction(int x, int y)
        {
            if (SelectedRectangle != null)
            {
                var action = SelectedRectangle.PossibleAction(x, y);
                if (action != PossibleAction.None)
                {
                    return action;
                }
            }

            int index = Rectangles.Count - 1;
            while (index >= 0)
            {
                if (Rectangles[index].IsPointInside(x, y))
                {
                    break;
                }

                index--;
            }

            if (index >= 0)
            {
                return PossibleAction.Select;
            }

            return PossibleAction.None;
        }

        public void RemoveSelected()
        {
            if (SelectedIndex < 0)
            {
                return;
            }

            int index = SelectedIndex;
            Select(-1);
            Rectangles.RemoveAt(index);
        }
    }
}
