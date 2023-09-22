using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZlateKnightF
{
    internal class Painter
    {
        private RectangleModel _mathRectangle = new RectangleModel
        {
            X = -12,
            Y = -8,
            Width = 24,
            Height = 16,
        };

        public void Paint(Graphics g, Rectangle clientRectangle)
        {
            var scaler = new Scaler(clientRectangle, _mathRectangle);
            var mainPen = new Pen(Color.Black, 3);

            var rect = new RectangleModel
            {
                X = -4,
                Y = -4,
                Width = 8,
                Height = 8,
            };

            g.FillEllipse(Brushes.Red, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -3.5,
                Y = -3.5,
                Width = 7,
                Height = 7,
            };

            g.FillEllipse(Brushes.Black, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -3,
                Y = -3,
                Width = 6,
                Height = 6,
            };

            g.FillEllipse(Brushes.Red, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -2.5,
                Y = -2.5,
                Width = 5,
                Height = 5,
            };

            g.FillEllipse(Brushes.Black, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -2,
                Y = -2,
                Width = 4,
                Height = 4,
            };


            g.FillEllipse(Brushes.Red, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1.5,
                Y = -1.5,
                Width = 3,
                Height = 3,
            };

            g.FillEllipse(Brushes.Black, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = -1,
                Width = 2,
                Height = 2,
            };

            g.FillEllipse(Brushes.White, scaler.Calculate(rect));


            rect = new RectangleModel
            {
                X = -0.5,
                Y = -0.5,
                Width = 1,
                Height = 1,
            };

            g.FillEllipse(Brushes.Red, scaler.Calculate(rect));



            rect = new RectangleModel
            {
                X = -4,
                Y = -4,
                Width = 8,
                Height = 8,
            };

            g.DrawPolygon(Pen., scaler.Calculate(rect));

        }
    }
}
