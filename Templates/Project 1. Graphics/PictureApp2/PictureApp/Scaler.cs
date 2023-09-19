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
        public Rectangle ScreenRectangle { get; set; }

        public RectangleModel MathRectangle { get; set; } = new RectangleModel
        {
            X = -9,
            Y = -1,
            Width = 18,
            Height = 11,
        };

        public Rectangle Calculate(RectangleModel rectangleModel)
        {
            var x = (int)(ScreenRectangle.X + (rectangleModel.Left - MathRectangle.Left) * ScreenRectangle.Width / Math.Abs(MathRectangle.Width));
            var y = (int)(ScreenRectangle.Y + (MathRectangle.Top - rectangleModel.Top) * ScreenRectangle.Height / Math.Abs(MathRectangle.Height));
            var width = (int)(ScreenRectangle.X + Math.Abs(rectangleModel.Width) * ScreenRectangle.Width / Math.Abs(MathRectangle.Width));
            var height = (int)(ScreenRectangle.Y + Math.Abs(rectangleModel.Height) * ScreenRectangle.Height / Math.Abs(MathRectangle.Height));

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
                X = (int)(ScreenRectangle.X + (x - MathRectangle.Left) * ScreenRectangle.Width / Math.Abs(MathRectangle.Width)),
                Y = (int)(ScreenRectangle.Y + (MathRectangle.Top - y) * ScreenRectangle.Height / Math.Abs(MathRectangle.Height)),
            };
        }

        public Point Calculate(PointModel pointModel)
        {
            return Calculate(pointModel.X, pointModel.Y);
        }
    }
}
