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
            if (MathRectangle == null)
            {
                return new Rectangle();
            }

            var x = (int)(ScreenRectangle.X + (rectangleModel.X - MathRectangle.X) * ScreenRectangle.Width / MathRectangle.Width);
            var y = (int)(ScreenRectangle.Y + (MathRectangle.Y + MathRectangle.Height - rectangleModel.Y) *
                ScreenRectangle.Height / MathRectangle.Height);
            var width = (int)(ScreenRectangle.X + rectangleModel.Width * ScreenRectangle.Width / MathRectangle.Width);
            var height = (int)(ScreenRectangle.Y - rectangleModel.Height * ScreenRectangle.Height / MathRectangle.Height);

            return new Rectangle
            {
                X = width > 0 ? x : x + width,
                Y = height > 0 ? y : y + height,
                Width = Math.Abs(width),
                Height = Math.Abs(height),
            };
        }
    }
}
