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
            var pen = new Pen(new SolidBrush(Color.Yellow), 20);
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
                Height = 5.6,
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

            //святая шестерёнка механикус
            rect = new RectangleModel
            {
                X = -4,
                Y = 2.6,
                Width = 4.5,
                Height = 4.5,
            };

            _graphics.DrawArc(pen, scaler.Calculate(rect), -80, 220);

            rect = new RectangleModel
            {
                X = -4,
                Y = 2.4,
                Width = 4.6,
                Height = 4.8,
            };
            var toothangle = 10;
            var angle = -75;
            pen = new Pen(new SolidBrush(Color.Yellow), 30);

            while (angle <= 130)
            {
                _graphics.DrawArc(pen, scaler.Calculate(rect), angle, toothangle);
                angle = angle + 20;
            }
            pen = new Pen(new SolidBrush(Color.Yellow), 20);

            points = new[]
            {
                new PointModel { X = -0.5, Y = 2.55 },
                new PointModel { X = 0.3, Y = 3.2 },
                new PointModel { X = -1, Y = 4.1 },
                new PointModel { X = -1.2, Y = 3 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Black, calculatedPoints);

            //мачете
            points = new[]
            {
                new PointModel { X = -1, Y = 3.9 },
                new PointModel { X = -1.7, Y = 4.4 },
                new PointModel { X = -2.3, Y = 5 },
                new PointModel { X = -2.4, Y = 4.7 },
                new PointModel { X = -2.4, Y = 4.3 },
                new PointModel { X = -2.3, Y = 4 },
                new PointModel { X = 0.5, Y = 2 },
                new PointModel { X = 0.8, Y = 2 },
                new PointModel { X = 1.1, Y = 1.85 },
                new PointModel { X = 1.4, Y = 1.4 },
                new PointModel { X = 1.6, Y = 1.7 },
                new PointModel { X = 1.5, Y = 2.2 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Yellow, calculatedPoints);

            points = new[]
            {
                new PointModel { X = -2, Y = 4.4 },
                new PointModel { X = -2, Y = 4.3 },
                new PointModel { X = 0.6, Y = 2.35 },
                new PointModel { X = 0.6, Y = 2.45 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Black, calculatedPoints);

            points = new[]
            {
                new PointModel { X = 0.9, Y = 3 },
                new PointModel { X = 0.8, Y = 3 },
                new PointModel { X = 0.4, Y = 2 },
                new PointModel { X = 0.5, Y = 2 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Black, calculatedPoints);
        }
    }
}
