using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    internal class Painter
    {
        private RectangleModel _mathRectangle = new RectangleModel
        {
            X = -11,
            Y = -11,
            Width = 22,
            Height = 22,
        };

        public void Paint(Graphics graphics, Rectangle clientRectangle)
        {
            var scaler = new Scaler(clientRectangle, _mathRectangle);

            var mainPen = new Pen(Color.Black, 2);
            graphics.DrawLine(mainPen, scaler.Calculate(0, 10), scaler.Calculate(0, 2));

            graphics.DrawLine(mainPen, scaler.Calculate(0, 10), scaler.Calculate(-1, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 10), scaler.Calculate(-2, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 9), scaler.Calculate(-3, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 8), scaler.Calculate(-4, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 7), scaler.Calculate(-5, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 6), scaler.Calculate(-6, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 5), scaler.Calculate(-7, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 4), scaler.Calculate(-8, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 3), scaler.Calculate(-9, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 2), scaler.Calculate(-10, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, 1), scaler.Calculate(-10, 0));

            graphics.DrawLine(mainPen, scaler.Calculate(-10, 0), scaler.Calculate(-2, 0));

            graphics.DrawLine(mainPen, scaler.Calculate(0, -10), scaler.Calculate(0, -2));

            graphics.DrawLine(mainPen, scaler.Calculate(0, -10), scaler.Calculate(-1, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -10), scaler.Calculate(-2, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -9), scaler.Calculate(-3, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -8), scaler.Calculate(-4, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -7), scaler.Calculate(-5, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -6), scaler.Calculate(-6, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -5), scaler.Calculate(-7, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -4), scaler.Calculate(-8, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -3), scaler.Calculate(-9, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -2), scaler.Calculate(-10, 0));
            graphics.DrawLine(mainPen, scaler.Calculate(0, -1), scaler.Calculate(-10, 0));

            graphics.DrawLine(mainPen, scaler.Calculate(10, 0), scaler.Calculate(2, 0));

            graphics.DrawLine(mainPen, scaler.Calculate(10, 0), scaler.Calculate(0, 1));
            graphics.DrawLine(mainPen, scaler.Calculate(10, 0), scaler.Calculate(0, 2));
            graphics.DrawLine(mainPen, scaler.Calculate(9, 0), scaler.Calculate(0, 3));
            graphics.DrawLine(mainPen, scaler.Calculate(8, 0), scaler.Calculate(0, 4));
            graphics.DrawLine(mainPen, scaler.Calculate(7, 0), scaler.Calculate(0, 5));
            graphics.DrawLine(mainPen, scaler.Calculate(6, 0), scaler.Calculate(0, 6));
            graphics.DrawLine(mainPen, scaler.Calculate(5, 0), scaler.Calculate(0, 7));
            graphics.DrawLine(mainPen, scaler.Calculate(4, 0), scaler.Calculate(0, 8));
            graphics.DrawLine(mainPen, scaler.Calculate(3, 0), scaler.Calculate(0, 9));
            graphics.DrawLine(mainPen, scaler.Calculate(2, 0), scaler.Calculate(0, 10));
            graphics.DrawLine(mainPen, scaler.Calculate(1, 0), scaler.Calculate(0, 10));



            graphics.DrawLine(mainPen, scaler.Calculate(10, 0), scaler.Calculate(0, -1));
            graphics.DrawLine(mainPen, scaler.Calculate(10, 0), scaler.Calculate(0, -2));
            graphics.DrawLine(mainPen, scaler.Calculate(9, 0), scaler.Calculate(0, -3));
            graphics.DrawLine(mainPen, scaler.Calculate(8, 0), scaler.Calculate(0, -4));
            graphics.DrawLine(mainPen, scaler.Calculate(7, 0), scaler.Calculate(0, -5));
            graphics.DrawLine(mainPen, scaler.Calculate(6, 0), scaler.Calculate(0, -6));
            graphics.DrawLine(mainPen, scaler.Calculate(5, 0), scaler.Calculate(0, -7));
            graphics.DrawLine(mainPen, scaler.Calculate(4, 0), scaler.Calculate(0, -8));
            graphics.DrawLine(mainPen, scaler.Calculate(3, 0), scaler.Calculate(0, -9));
            graphics.DrawLine(mainPen, scaler.Calculate(2, 0), scaler.Calculate(0, -10));
            graphics.DrawLine(mainPen, scaler.Calculate(1, 0), scaler.Calculate(0, -10));

            var rect = new RectangleModel
            {
                X = -2,
                Y = -2,
                Width = 4,
                Height = 4,
            };

            
            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));
        }
    }
}
