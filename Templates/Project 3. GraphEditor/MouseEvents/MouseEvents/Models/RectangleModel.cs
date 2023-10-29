﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseEvents.Models
{
    internal class RectangleModel
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Left => Width > 0 ? X : X + Width;

        public int Right => Width > 0 ? X + Width : X;

        public int Bottom => Height > 0 ? Y + Height : Y;

        public int Top => Height > 0 ? Y : Y + Height;

        public bool DrawMode { get; private set; }

        public bool IsSelected { get; private set; }

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
            DrawMode = true;
            X = x;
            Y = y;
            Width = 0;
            Height = 0;
        }

        public void ResetDrawMode()
        {
            DrawMode = false;
            Normalize();
        }

        public void Draw(int x, int y)
        {
            if (!DrawMode)
            {
                return;
            }

            Width = x - X;
            Height = y - Y;
        }

        public bool IsPointInside(int x, int y)
        {
            return x >= Left && x <= Right && y >= Top && y <= Bottom;
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