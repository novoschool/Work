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

        public void Paint(Graphics _graphics, Rectangle _clientRectangle)
        {
            var mainPen = new Pen(Color.Black, 3);
            var scaler = new Scaler(_clientRectangle, _mathRectangle);

            var rect = new RectangleModel
            {
                X = -9.5,
                Y = 4.5,
                Width = 18,
                Height = 5.5,
            };

            _graphics.FillRectangle(new SolidBrush(Color.Red), scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -9.5,
                Y = -1,
                Width = 18,
                Height = 5.5,
            };

            _graphics.FillRectangle(new SolidBrush(Color.Black), scaler.Calculate(rect));

            var points = new[]
            {
                new PointModel { X = -2, Y = 4.8 },
                new PointModel { X = -1.7, Y = 5.6 },
                new PointModel { X = -2.3, Y = 6 },
                new PointModel { X = -1.6, Y = 6 },
                new PointModel { X = -1.5, Y = 6.7 },
                new PointModel { X = -1.4, Y = 6 },
                new PointModel { X = -0.8, Y = 6 },
                new PointModel { X = -1.3, Y = 5.6 },
                new PointModel { X = -1, Y = 4.8 },
                new PointModel { X = -1.5, Y = 5.5 }
            };
            var calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Yellow, calculatedPoints);

            points = new[]
            {
                new PointModel { X = -2.3, Y = 4.8 },
                new PointModel { X = 1, Y = 1 },
                new PointModel { X = 0, Y = 0 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Blue, calculatedPoints);
        }
    }
}
