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
            Width = 2000,
            Height = 1000,
        };

        public void Paint(Graphics graphics, Rectangle clientRectangle)
        {

            var mainPen = new Pen(Color.Black, 3);
            var scaler = new Scaler(clientRectangle, _mathRectangle);
            var BluePen = new Pen(Color.DarkBlue, scaler.CalculateWidth(27));
            var BlackPen = new Pen(Color.Black, scaler.CalculateWidth(27));
            var RedPen = new Pen(Color.DarkRed, scaler.CalculateWidth(27));
            var YellowPen = new Pen(Color.Yellow, scaler.CalculateWidth(27));
            var GreenPen = new Pen(Color.DarkGreen, scaler.CalculateWidth(27));
            var GrayPen = new Pen(Color.DarkGray, scaler.CalculateWidth(27));

            var rect = new RectangleModel
            {
                X = 510,
                Y = 490,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GrayPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 860,
                Y = 490,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GrayPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1210,
                Y = 490,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GrayPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 685,
                Y = 340,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GrayPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1035,
                Y = 340,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GrayPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 500,
                Y = 500,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(BluePen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 850,
                Y = 500,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(BlackPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1200,
                Y = 500,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(RedPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 675,
                Y = 350,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(YellowPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1025,
                Y = 350,
                Width = 300,
                Height = 300,
            };
            graphics.DrawEllipse(GreenPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 787,
                Y = 630,
                Width = 28,
                Height = 32,
            };
            graphics.FillRectangle(Brushes.DarkBlue, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1135,
                Y = 630,
                Width = 28,
                Height = 32,
            };
            graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 960,
                Y = 487,
                Width = 30,
                Height = 28,
            };
            graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 1310,
                Y = 487,
                Width = 30,
                Height = 28,
            };
            graphics.FillRectangle(Brushes.DarkRed, scaler.Calculate(rect));


            

        }
    }
}
