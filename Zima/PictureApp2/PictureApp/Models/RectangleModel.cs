using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp.Models
{
    internal class RectangleModel
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Left => Width > 0 ? X : X + Width;

        public double Right => Width > 0 ? X + Width : X;

        public double Bottom => Height > 0 ? Y : Y + Height;

        public double Top => Height > 0 ? Y + Height : Y;

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
    }
}
