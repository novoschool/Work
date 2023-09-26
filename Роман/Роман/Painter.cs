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
                X = 12,
                Y = 0,
                Width = 4,
                Height = 8,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 7,
                Y = 4,
                Width = 5,
                Height = 2,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 10,
                Y = 0,
                Width = 5,
                Height = 4,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 4,
                Width = 5,
                Height = 2,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = 0,
                Width = 5,
                Height = 3,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 5,
                Y = 5,
                Width = 5,
                Height = 4,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 3,
                Y = 0,
                Width = 5,
                Height = 1,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 4,
                Y = 0,
                Width = 5,
                Height = 2,
            };

            g.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawArc(mainPen, 320, 20, 150, 150, 250, 400);

            rect = new RectangleModel
            {
                X = 1,
                Y = 0,
                Width = 5,
                Height = 2,
            };

            g.FillPie(Brushes.DarkGray, 50, 20, 250, 70, 250, 400);
            g.DrawArc(mainPen, 50, 20, 250, 70, 250, 400);

            g.FillPie(Brushes.DarkGray, 500, 20, 250, 70, 250, 400);
            g.DrawArc(mainPen, 500, 20, 250, 70, 250, 400);

            var points = new[]
            {
                new Point(350, 300),
                new Point(380, 300),
                new Point(400, 250),
                new Point(500, 300),
            };
            g.FillPolygon(Brushes.DarkGray, points);
            g.DrawPolygon(mainPen, points);
        }
    }
}
