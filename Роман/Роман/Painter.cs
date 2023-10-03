using PictureApp;
using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Роман
{
    internal class Painter
    {
        private RectangleModel _mathRectangle = new RectangleModel
        {
            X = -1,
            Y = -1,
            Width = 18,
            Height = 12,
        };

        public void Paint(Graphics g, Rectangle clientRectangle)
        {
            var scaler = new Scaler(clientRectangle, _mathRectangle);
            var mainPen = new Pen(Color.Black, 3);

            var rect = new RectangleModel
            {
                X = 15,
                Y = 0,
                Width = 1,
                Height = 8,
            };

            g.FillRectangle(Brushes.Aqua, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 7,
                Y = 4,
                Width = 5,
                Height = 2,
            };

            g.FillRectangle(Brushes.Aqua, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 10,
                Y = 0,
                Width = 5,
                Height = 4,
            };

            g.FillRectangle(Brushes.Aqua, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 3,
                Width = 11,
                Height = 1,
            };

            g.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 0,
                Width = 5,
                Height = 3,
            };

            g.FillRectangle(Brushes.Aqua, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 3,
                Width = 5,
                Height = 4,
            };

            g.FillRectangle(Brushes.Aqua, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 4,
                Y = 0,
                Width = 6,
                Height = 1,
            };

            g.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 5,
                Y = 9,
                Width = 5,
                Height = 2,
            };

            g.FillEllipse(Brushes.Azure, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 11,
                Y = 9,
                Width = 5,
                Height = 2,
            };

            g.FillEllipse(Brushes.Azure, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 9,
                Width = 5,
                Height = 2,
            };

            g.FillEllipse(Brushes.Azure, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 8,
                Y = 10,
                Width = 5,
                Height = 2,
            };


            var points = new[]
            {
                new PointModel { X = 12, Y = 6 },
                new PointModel { X = 7.1, Y = 6 },
                new PointModel { X = 10, Y = 8 },
            };
            var calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.AntiqueWhite, calculatedPoints);
            g.DrawPolygon(mainPen, calculatedPoints);

            points = new[]
            {
                new PointModel { X = -1, Y = 7 },
                new PointModel { X = 4, Y = 7 },
                new PointModel { X = 2, Y = 9 },
            };
            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.AntiqueWhite, calculatedPoints);
            g.DrawPolygon(mainPen, calculatedPoints);
        }
    }
}
