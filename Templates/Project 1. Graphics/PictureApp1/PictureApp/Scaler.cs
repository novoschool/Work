using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    internal class Scaler
    {
        public Rectangle ScreenRectangle { get; set; }

        public double XMinM { get; set; } = -9;

        public double XMaxM { get; set; } = 9;

        public double YMinM { get; set; } = -1;

        public double YMaxM { get; set; } = 10;

        public Rectangle Calculate(double xM, double yM, double widthM, double heightM)
        {
            return new Rectangle
            {
                X = (int)(ScreenRectangle.X + (xM - XMinM) * ScreenRectangle.Width / (XMaxM - XMinM)),
                Y = (int)(ScreenRectangle.Y + (YMaxM - yM) * ScreenRectangle.Height / (YMaxM - YMinM)),
                Width = (int)(ScreenRectangle.X + widthM * ScreenRectangle.Width / (XMaxM - XMinM)),
                Height = (int)(ScreenRectangle.Y - heightM * ScreenRectangle.Height / (YMaxM - YMinM)),
            };
        }
    }
}
