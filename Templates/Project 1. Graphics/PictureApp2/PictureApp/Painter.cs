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
            var mainPen = new Pen(Color.Black, 1);
            var scaler = new Scaler(_clientRectangle, _mathRectangle);

            var rect = new RectangleModel  // корпус дома
            {
                X = -7,
                Y = 1,
                Width = 12,
                Height = 8,
            };

            _graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно 1
            {
                X = -6.5,
                Y = 6,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
            
            rect = new RectangleModel  // окно 2
            {
                X = -6.5,
                Y = 2,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.GreenYellow, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно 3
            {
                X = 2.5,
                Y = 2,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.YellowGreen, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно 4
            {
                X = 2.5,
                Y = 6,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Goldenrod, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // балкон
            {
                X = -3,
                Y = 5.5,
                Width = 4,
                Height = 3,
            };

            _graphics.FillRectangle(Brushes.AliceBlue, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно малое
            {
                X = -3.5,
                Y = 2,
                Width = 1.2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.AliceBlue, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));



            rect = new RectangleModel  // линия ограничения горизонтальная
            {
                X = -7,
                Y = 5,
                Width = 12,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия ограничения вертикальная слева
            {
                X = -4,
                Y = 1,
                Width = 0.2,
                Height = 8,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия ограничения вертикальная справа
            {
                X = 1.8,
                Y = 1,
                Width = 0.2,
                Height = 8,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
           
            rect = new RectangleModel  // подъезд
            {
                X = -2,
                Y = 1,
                Width = 3.5,
                Height = 3.5,
            };

            _graphics.FillRectangle(Brushes.Gray, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на подъезде
            {
                X = 0,
                Y = 1,
                Width = 0.1,
                Height = 3.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на окне
            {
                X = -2.9,
                Y = 2,
                Width = 0.05,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на окне
            {
                X = 3.5,
                Y = 2,
                Width = 0.05,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на окне
            {
                X = 3.5,
                Y = 6,
                Width = 0.05,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на окне
            {
                X = -5.5,
                Y = 6,
                Width = 0.05,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на окне
            {
                X = -5.5,
                Y = 2,
                Width = 0.05,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // горизонтальная линия на балконе
            {
                X = -3,
                Y = 6.5,
                Width = 4,
                Height = 0.05,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на балконе
            {
                X = -2.5,
                Y = 5.5,
                Width = 0.1,
                Height = 1,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на балконе
            {
                X = -1.5,
                Y = 5.5,
                Width = 0.1,
                Height = 1,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на балконе
            {
                X = -0.5,
                Y = 5.5,
                Width = 0.1,
                Height = 1,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // линия на балконе
            {
                X = 0.5,
                Y = 5.5,
                Width = 0.1,
                Height = 1,
            };

            _graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // домофон
            {
                X = 0.25,
                Y = 2,
                Width = 1,
                Height = 1.5,
            };

            _graphics.FillRectangle(Brushes.Brown, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // табло домофона
            {
                X = 0.35,
                Y = 3,
                Width = 0.8,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.35,
                Y = 2.5,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.65,
                Y = 2.5,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
           
            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.95,
                Y = 2.5,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.95,
                Y = 2.2,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.65,
                Y = 2.2,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.35,
                Y = 2.2,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = 0.35,
                Y = 2.2,
                Width = 0.2,
                Height = 0.2,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // кнопки домофона
            {
                X = -0.5,
                Y = 2.5,
                Width = 0.4,
                Height = 0.4,
            };

            _graphics.FillEllipse(Brushes.Black, scaler.Calculate(rect));
            _graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            var points = new[]
            {
                new PointModel{ X = -8, Y = 9 },
                new PointModel{ X = -7, Y = 10 },
                new PointModel{ X = 5, Y = 10 },
                new PointModel{ X = 6, Y = 9 },
            };
            var calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            _graphics.FillPolygon(Brushes.Black, calculatedPoints);
        }
    }
}
