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
            X = 0,
            Y = 0,
            Width = 16,
            Height = 9,
        };

        public void Paint(Graphics g, Rectangle clientRectangle)
        {
            var mainPen = new Pen(Color.Yellow, 3);
            var scaler = new Scaler(clientRectangle, _mathRectangle);



            var points = new[]
            {
                new PointModel { X = 3, Y = 8 },
                new PointModel { X = 2.7, Y = 7 },
                new PointModel { X = 3.3, Y = 7 },

                new PointModel { X = 4.1, Y = 7},
                new PointModel { X = 3.5, Y = 6.45},

                new PointModel { X = 3.9, Y = 5.6},
                new PointModel { X = 3, Y = 6.1},

                new PointModel { X = 2.1, Y = 5.6},
                new PointModel { X = 2.5, Y = 6.45},

                new PointModel { X = 1.9, Y = 7},
                new PointModel { X = 3.3, Y = 7},

            };
            var calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPoints);
            g.DrawPolygon(mainPen, calculatedPoints);

            /*
             * X средняя 3, max - 4.1, min - 1.9
             * y max - 8, min - 5.6
             * 
             */
            var pointsR = new[]
            {
                new PointModel { X = 4.5, Y = 7.8 },
              

            };
            var calculatedPointsR = pointsR.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPointsR);
            g.DrawPolygon(mainPen, calculatedPointsR);
        }
    }
}
