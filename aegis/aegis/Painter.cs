using PictureApp.Models;
using PictureApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            var mainPen = new Pen(Color.Black, 1);


            g.FillRectangle(Brushes.Green, 50, 100, 200, 300);
            g.DrawRectangle(mainPen, 50, 100, 200, 300);


            g.FillRectangle(Brushes.White, 250, 100, 200, 300);
            g.DrawRectangle(mainPen, 250, 100, 200, 300);


            g.FillRectangle(Brushes.Red, 400, 100, 200, 300);
            g.DrawRectangle(mainPen, 400, 100, 200, 300);
        }
    }
}
