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

            SolidBrush PenKitaetc = new SolidBrush(Color.FromArgb(201, 162, 83));
            SolidBrush shapochka = new SolidBrush(Color.FromArgb(156, 128, 72));
            SolidBrush eye = new SolidBrush(Color.Black);
            var mainPen = new Pen(Color.Yellow, 3);
            var scaler = new Scaler(clientRectangle, _mathRectangle);
            var rect = new RectangleModel
            {
                X = 11.5,
                Y = 0.5,
                Width = 4,
                Height = 4,
            };

            g.FillEllipse(PenKitaetc, scaler.Calculate(rect));


            rect = new RectangleModel
            {
                X = 12,
                Y = 3,
                Width = 1,
                Height = 0.1,
            };
            g.FillRectangle(eye, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 14,
                Y = 3,
                Width = 1,
                Height = 0.1,
            };
            g.FillRectangle(eye, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 13.2,
                Y = 1.2,
                Width = 0.7,
                Height = 0.9,
            };

            g.FillEllipse(eye, scaler.Calculate(rect));

            var S = new[]
           {
                new PointModel { X = 11, Y = 3.5 },
                new PointModel { X = 16, Y = 3.5 },
                new PointModel { X = 13.5, Y = 5.5 },


            };
            var calculatedPointsC = S.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(shapochka, calculatedPointsC);



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

                new PointModel { X = 5.75, Y = 5.35 },
                new PointModel { X = 5.5, Y = 5.5 },

                new PointModel { X = 5.25, Y = 5.35 },
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


            var pointsF = new[]
            {
                new PointModel { X = 5.35, Y = 8 },
                new PointModel { X = 5.15, Y = 7.92 },
                new PointModel {X = 5.15, Y = 8.06},

                new PointModel {X = 5.13, Y = 8.27 },
                new PointModel {X = 5, Y = 8.07 },

               new PointModel {X = 4.8, Y = 8.15},
               new PointModel {X = 4.95, Y = 8},

               new PointModel { X = 4.8, Y = 7.85 },
               new PointModel { X = 5, Y = 7.9 },

               new PointModel { X = 5.15, Y = 7.7 },
               new PointModel { X = 5.15, Y = 8.06 },



            };
            var calculatedPointsF = pointsF.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPointsF);
            g.DrawPolygon(mainPen, calculatedPointsF);

            var pointsA = new[]
           {
                new PointModel { X = 5.35, Y = 4.5 },
                new PointModel { X = 5.15, Y = 4.42 },
                new PointModel {X = 5.15, Y = 4.56},

                new PointModel {X = 5.13, Y = 4.77 },
                new PointModel {X = 5, Y = 4.57 },

               new PointModel {X = 4.8, Y = 4.65},
               new PointModel {X = 4.95, Y = 4.5},

               new PointModel { X = 4.8, Y = 4.35 },
               new PointModel { X = 5, Y = 4.4 },

               new PointModel { X = 5.15, Y = 4.2 },
               new PointModel { X = 5.15, Y = 4.56 },



            };
            var calculatedPointsA = pointsA.Select(p => scaler.Calculate(p)).ToArray();
            g.FillPolygon(Brushes.Yellow, calculatedPointsA);
            g.DrawPolygon(mainPen, calculatedPointsA);

            


        }
    }
}
