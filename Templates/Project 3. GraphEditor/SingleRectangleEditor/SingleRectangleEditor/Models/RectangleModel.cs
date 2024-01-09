using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRectangleEditor.Models
{
    internal class RectangleModel
    {
        private int _dx;

        private int _dy;

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Left => Width > 0 ? X : X + Width;

        public int Right => Width > 0 ? X + Width : X;

        public int Bottom => Height > 0 ? Y + Height : Y;

        public int Top => Height > 0 ? Y : Y + Height;

        public bool IsSelected { get; private set; }

        public FigureActionMode ActionMode { get; private set; }

        public bool IsAction => ActionMode != FigureActionMode.None;

        public int MarkerHalfWidth { get; } = 3;

        public int MarkerHalfHeight { get; } = 3;

        public void Normalize()
        {
            if (Width < 0)
            {
                X += Width;
                Width = -Width;
            }

            if (Height < 0)
            {
                Y += Height;
                Height = -Height;
            }
        }

        public void SetDrawMode(int x, int y)
        {
            ActionMode = FigureActionMode.Drawing;
            X = x;
            Y = y;
            Width = 0;
            Height = 0;
        }

        public void ResetMode()
        {
            ActionMode = FigureActionMode.None;
            Normalize();
        }

        public void Draw(int x, int y)
        {
            if (ActionMode != FigureActionMode.Drawing)
            {
                return;
            }

            Width = x - X;
            Height = y - Y;
        }

        public void SetMovingMode(int x, int y)
        {
            ActionMode = FigureActionMode.Moving;
            _dx = x - X;
            _dy = y - Y;
        }

        public void Move(int x, int y)
        {
            if (ActionMode != FigureActionMode.Moving)
            {
                return;
            }

            X = x - _dx;
            Y = y - _dy;
        }

        public void SetResizingBottomRightMode(int x, int y)
        {
            ActionMode = FigureActionMode.ResizingBottomRight;
        }

        public void SetActionMode(int x, int y)
        {
            switch (PossibleAction(x, y))
            {
                case Models.PossibleAction.Draw:
                    SetDrawMode(x, y);
                    break;
                case Models.PossibleAction.Move:
                    SetMovingMode(x, y);
                    break;
                case Models.PossibleAction.ResizeBottomRight:
                    SetResizingBottomRightMode(x, y);
                    break;
                default:
                    break;
            }
        }

        public void DoAction(int x, int y)
        {
            switch (ActionMode)
            {
                case FigureActionMode.Drawing:
                    Draw(x, y);
                    break;
                case FigureActionMode.Moving:
                    Move(x, y);
                    break;
                case FigureActionMode.ResizingBottomRight:
                    ResizeBottomRight(x, y);
                    break;
                default:
                    break;
            }
        }

        public void ResizeBottomRight(int x, int y)
        {
            if (ActionMode!= FigureActionMode.ResizingBottomRight)
            {
                return;
            }

            Width = x - X;
            Height = y - Y;
        }

        public bool IsPointInside(int x, int y)
        {
            return IsPointInside(x, y, Left, Right, Top, Bottom);
        }

        public bool IsPointInside(int x, int y, int left, int right, int top, int bottom)
        {
            return x >= left && x <= right && y >= top && y <= bottom;
        }

        public void CheckAndSelect(int x, int y)
        {
            if (IsPointInside(x, y))
            {
                IsSelected = true;
                return;
            }

            IsSelected = false;
        }

        public PossibleAction PossibleAction(int x, int y)
        {
            if (!IsSelected)
            {
                if (IsPointInside(x, y))
                {
                    return Models.PossibleAction.Select;
                }

                return Models.PossibleAction.None;
            }

            if (!IsPointInside(x, y))
            {
                return Models.PossibleAction.None;
            }

            if (IsPointInside(x, y, Right - MarkerHalfWidth, Right + MarkerHalfWidth, Bottom - MarkerHalfHeight, Bottom + MarkerHalfHeight))
            {
                return Models.PossibleAction.ResizeBottomRight;
            }

            return Models.PossibleAction.Move;
        }

        public void Select()
        {
            IsSelected = true;
        }

        public void Deselect()
        {
            IsSelected = false;
        }
    }
}
