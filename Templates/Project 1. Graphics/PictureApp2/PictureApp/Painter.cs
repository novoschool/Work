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

                new PointModel { X = 3.9, Y = 5.6}, //2
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
                new PointModel { X = 5.5, Y = 6.1 },
                new PointModel { X = 5.4, Y = 5.8 },
                new PointModel { X = 5.6, Y = 5.8 },

                new PointModel { X = 5.8, Y = 5.8 },
                new PointModel { X = 5.65, Y = 5.6 },

                new PointModel { X = 5.8, Y = 5.35 },
                new PointModel { X = 5.5, Y = 5.5 },

                new PointModel { X = 5.2, Y = 5.35 },
                new PointModel { X = 5.35, Y = 5.6 },

                new PointModel { X = 5.2, Y = 5.8 },
                new PointModel { X = 5.6, Y = 5.8 },
            };


            var calculatedPointsR = pointsR.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPointsR);
            g.DrawPolygon(mainPen, calculatedPointsR);

            var pointsE = new[]
            {
                new PointModel { X = 5.35, Y = 7 },
                new PointModel { X = 5.55, Y =  6.9 },
                new PointModel { X = 5.55, Y = 7.06},

                new PointModel { X = 5.55, Y = 7.27 },
                new PointModel { X = 5.7, Y = 7.12 },

                new PointModel { X = 5.88, Y = 7.18 },
                new PointModel { X = 5.78, Y = 7 },

                new PointModel { X = 5.9, Y = 6.84 },
                new PointModel { X = 5.7, Y = 6.9 },


                new PointModel { X = 5.6, Y = 6.7 },
                new PointModel { X = 5.55, Y = 7.06 },

            };
            var calculatedPointsE = pointsE.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPointsE);
            g.DrawPolygon(mainPen, calculatedPointsE);


        }
    }
}
