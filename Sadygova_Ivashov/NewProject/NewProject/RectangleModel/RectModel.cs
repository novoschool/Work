using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject.RectangleModel
{
    internal class RectModel
    {
        public int X { get; set; }  
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Left => Width > 0 ? X : X + Width;

        public int Right => Width > 0 ? Y : Y + Width;

        public int Bottom => Height > 0 ? Y : Y + Height;


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

        private void ResetDrawMode()
        {
            DrawMode = false;
            Normalize();
        }

        public void 
    }
}
