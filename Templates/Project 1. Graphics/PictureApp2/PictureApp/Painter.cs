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

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
            
            rect = new RectangleModel  // окно 2
            {
                X = -6.5,
                Y = 2,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно 3
            {
                X = 2.5,
                Y = 2,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно 4
            {
                X = 2.5,
                Y = 6,
                Width = 2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // балкон
            {
                X = -3,
                Y = 5.5,
                Width = 4,
                Height = 3,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            _graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel  // окно малое
            {
                X = -3.2,
                Y = 2,
                Width = 1.2,
                Height = 2.5,
            };

            _graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
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

        }
    }
}
