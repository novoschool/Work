using PictureApp.Models;
using PictureApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace aegis
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

        public void Paint(Graphics graphics, Rectangle clientRectangle)
        {
            var scaler = new Scaler(clientRectangle, _mathRectangle);
            var mainPen = new Pen(Color.Black, 3);
            {
                var rect = new RectangleModel
                {
                    X = 3,
                    Y = -2,
                    Width = 3,
                    Height = 7, 
                };
                graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 6,
                    Y = -3,
                    Width = 3,
                    Height = 7,
                };
                graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 1,
                    Y = -1,
                    Width = 3,
                    Height = 5,
                };
                graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 1.3,
                    Y = 2,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 2.6,
                    Y = 2,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 2.8,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 1.3,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 2.6,
                    Y = 0.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 1.3,
                    Y = 0.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 6.5,
                    Y = 0.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 6.5,
                    Y = 2.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 4.5,
                    Y = 2.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 4.5,
                    Y = 0.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 4.5,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 6.5,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -2,
                    Y = -1,
                    Width = 3,
                    Height = 6,
                };
                graphics.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -1.5,
                    Y = 2.9,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                rect = new RectangleModel
                {
                    X = 0.1,
                    Y = 2.9,
                    Width = 0.9,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 0.1,
                    Y = 1.5,
                    Width = 0.9,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -1.5,
                    Y = 1.5,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -1.5,
                    Y = 0.2,
                    Width = 1,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 0.1,
                    Y = 0.2,
                    Width = 0.9,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Yellow, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = 0.1,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -1.4,
                    Y = -1,
                    Width = 0.7,
                    Height = 1,
                };
                graphics.FillRectangle(Brushes.Black, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));

                rect = new RectangleModel
                {
                    X = -9,
                    Y = -1,
                    Width = 5,
                    Height = 5,
                };
                graphics.FillRectangle(Brushes.Gray, scaler.Calculate(rect));
                graphics.DrawRectangle(mainPen, scaler.Calculate(rect));
                //var image = Image.FromFile("MyPicture.png");
                //graphics.DrawImage(image, scaler.Calculate(rect));
            }


        }

    }

}
