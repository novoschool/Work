using stepR.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepR
{
    internal class Painter
    {
        private RectangleModel _mathRectangle = new RectangleModel
        {
            X = -25,
            Y = -25,
            Width = 50,
            Height = 50,
        };

        public void Paint(Graphics graphics, Rectangle clientRectangle)
        {

            var scaler = new Scaler(clientRectangle, _mathRectangle);

            var mainPen = new Pen(Color.Black, 2);

            var points = new[]
            {
                new PointModel {X = 0, Y = 18},
                new PointModel {X = 2, Y = 12},
                new PointModel {X = 2, Y = -14},
                new PointModel {X = -2, Y = -14},
                new PointModel {X = -2, Y = 12},
            };
            
            
            var calculatedPoints = points.Select( p=> scaler.Calculate(p)). ToArray();
            graphics.DrawPolygon(mainPen, calculatedPoints);

             points = new[]
            {
                new PointModel {X = 5.5, Y = 5},
                new PointModel {X = 7, Y = 1},
                new PointModel {X = 7, Y = -14},
                new PointModel {X = 4, Y = -14},
                new PointModel {X = 4, Y = 1},
            };

             calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            graphics.DrawPolygon(mainPen, calculatedPoints);


            graphics.DrawLine(mainPen, scaler.Calculate(5, -14), scaler.Calculate(4, -16));
            graphics.DrawLine(mainPen, scaler.Calculate(6, -14), scaler.Calculate(7, -16));

            graphics.DrawLine(mainPen, scaler.Calculate(-5, -14), scaler.Calculate(-4, -16));
            graphics.DrawLine(mainPen, scaler.Calculate(-6, -14), scaler.Calculate(-7, -16));

            graphics.DrawLine(mainPen, scaler.Calculate(-2, -14), scaler.Calculate(-3, -18));
            graphics.DrawLine(mainPen, scaler.Calculate(-3, -18), scaler.Calculate(-3, -19.6));

            graphics.DrawLine(mainPen, scaler.Calculate(-1, -14), scaler.Calculate(-1, -20));
            graphics.DrawLine(mainPen, scaler.Calculate(1, -14), scaler.Calculate(1, -19.6));

            graphics.DrawLine(mainPen, scaler.Calculate(2, -14), scaler.Calculate(3, -18));
            graphics.DrawLine(mainPen, scaler.Calculate(-3, -18), scaler.Calculate(-3, -19.7));

            graphics.DrawLine(mainPen, scaler.Calculate(3, -18), scaler.Calculate(3, -19.7));
            

            points = new[]
            {
                
                new PointModel {X = -4, Y = 1},
                new PointModel {X = -5.5, Y = 5},
                new PointModel {X = -7, Y = 1},
                new PointModel {X = -7, Y = -14},
                new PointModel {X = -4, Y = -14},
            };


            calculatedPoints = points.Select(p => scaler.Calculate(p)).ToArray();
            graphics.DrawPolygon(mainPen, calculatedPoints);


            var rect = new RectangleModel
            {
                X = 4,
                Y = 0,
                Width = 3,
                Height = 2,
            };

           
            graphics.DrawArc(mainPen, scaler.Calculate(rect), 0, 180) ;

             rect = new RectangleModel
            {
                X = -7,
                Y = 0,
                Width = 3,
                Height = 2,
            };


            graphics.DrawArc(mainPen, scaler.Calculate(rect), 0, 180);


             rect = new RectangleModel
            {
                X = -2,
                Y = 11,
                Width = 4,
                Height = 2,
            };


            graphics.DrawArc(mainPen, scaler.Calculate(rect), 0, 180);

            rect = new RectangleModel
            {
                X = -7,
                Y = -17,
                Width = 3,
                Height = 2,
            };


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 4,
                Y = -17,
                Width = 3,
                Height = 2,
            };


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -1,
                Y = -20,
                Width = 2,
                Height = 1,
            };


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1,
                Y = -20,
                Width = 2,
                Height = 1,
            };


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -3,
                Y = -20,
                Width = 2,
                Height = 1,
            };


            graphics.DrawEllipse(mainPen, scaler.Calculate(rect));


            rect = new RectangleModel
            {
               
            };

            graphics.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            graphics.DrawRectangle(mainPen, scaler.Calculate(rect));


        }

    }
}
