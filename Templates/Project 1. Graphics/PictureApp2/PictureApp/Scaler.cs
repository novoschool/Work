using PictureApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    internal class Scaler
    {
        private Rectangle _screenRectangle { get; set; }

        private RectangleModel _mathRectangle { get; set; } = new RectangleModel
        {
            X = -9,
            Y = -1,
            Width = 17,
            Height = 11,
        };

        public Scaler(Rectangle screenRectangle, RectangleModel mathRectangle)
        {
            _screenRectangle = screenRectangle;
            _mathRectangle = mathRectangle;
            _mathRectangle.Normalize();

            if (_mathRectangle.Width * _screenRectangle.Height > _screenRectangle.Width * _mathRectangle.Height)
            {
                // Добавки сверху и снизу
                var newHeight = _mathRectangle.Width * _screenRectangle.Height / _screenRectangle.Width;
                var dy = newHeight - _mathRectangle.Height;
                _mathRectangle.Y -= dy / 2;
                _mathRectangle.Height = newHeight;
            }
            else
            {
                // Добавки слева и справа
                var newWidth = _mathRectangle.Height * _screenRectangle.Width / _screenRectangle.Height;
                var dx = newWidth - _mathRectangle.Width;
                _mathRectangle.X -= dx / 2;
                _mathRectangle.Width = newWidth;
            }
        }

        public Rectangle Calculate(RectangleModel rectangleModel)
        {
            var x = (int)(_screenRectangle.X + (rectangleModel.Left - _mathRectangle.Left) * _screenRectangle.Width / Math.Abs(_mathRectangle.Width));
            var y = (int)(_screenRectangle.Y + (_mathRectangle.Top - rectangleModel.Top) * _screenRectangle.Height / Math.Abs(_mathRectangle.Height));
            var width = (int)(_screenRectangle.X + Math.Abs(rectangleModel.Width) * _screenRectangle.Width / Math.Abs(_mathRectangle.Width));
            var height = (int)(_screenRectangle.Y + Math.Abs(rectangleModel.Height) * _screenRectangle.Height / Math.Abs(_mathRectangle.Height));

            return new Rectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
            };
        }

        public Point Calculate(double x, double y)
        {
            return new Point
            {
                X = (int)(_screenRectangle.X + (x - _mathRectangle.Left) * _screenRectangle.Width / Math.Abs(_mathRectangle.Width)),
                Y = (int)(_screenRectangle.Y + (_mathRectangle.Top - y) * _screenRectangle.Height / Math.Abs(_mathRectangle.Height)),
            };
        }

        public Point Calculate(PointModel pointModel)
        {
            return Calculate(pointModel.X, pointModel.Y);
        }
    }
}
