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

        public int CalculateWidth(double width)
        {
            return Math.Max((int)(_screenRectangle.X + width * _screenRectangle.Width / Math.Abs(_mathRectangle.Width)), 1);
        }
    }
}
