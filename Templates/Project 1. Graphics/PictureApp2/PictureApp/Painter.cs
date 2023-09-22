using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    internal class Painter
    {
        private RectangleModel _mathRectangle = new RectangleModel
        {
            X = -9,
            Y = -1,
            Width = 17,
            Height = 11,
        };

        public void Paint(Graphics graphics, Rectangle clientRectangle)
        {
            var mainPen = new Pen(Color.Black, 3);
            var scaler = new Scaler(clientRectangle, _mathRectangle);

            var rect = new RectangleModel
            {
                X = -8,
                Y = 2,
                Width = 3,
                Height = 7,
            };

            graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -6.5,
                Y = 6,
                Width = 1,
                Height = 2,
            };

            graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -5,
                Y = 2,
                Width = 11,
                Height = 4,
            };

            graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -6,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            graphics.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -3,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            graphics.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 0,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            graphics.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 3,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            graphics.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 5,
                Y = 2,
                Width = 2,
                Height = 4,
            };

            graphics.FillPie(Brushes.DarkGray, scaler.Calculate(rect), 270, 180);
            graphics.DrawArc(mainPen, scaler.Calculate(rect), 270, 180);

            var points = new[]
            {
                new PointModel { X = 3, Y = 6 },
                new PointModel { X = 2.5, Y = 9 },
                new PointModel { X = 4.5, Y = 9 },
                new PointModel { X = 4, Y = 6 },
            };
            var calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            graphics.FillPolygon(Brushes.DarkGray, calculatedPoints);
            graphics.DrawPolygon(mainPen, calculatedPoints);
        }
    }
}
