using PictureApp.Models;

namespace PictureApp
{
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();
        }

        private void PictureForm_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var mainPen = new Pen(Color.Black, 3);
            var scaler = new Scaler();
            scaler.ScreenRectangle = ClientRectangle;

            var rect = new RectangleModel
            {
                X = -8,
                Y = 2,
                Width = 3,
                Height = 7,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -6.5,
                Y = 6,
                Width = 1,
                Height = 2,
            };

            g.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -5,
                Y = 2,
                Width = 11,
                Height = 4,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -6,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            g.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -3,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            g.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 0,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            g.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 3,
                Y = 0,
                Width = 2,
                Height = 2,
            };

            g.FillEllipse(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawEllipse(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = 4,
                Y = 2,
                Width = 4,
                Height = 4,
            };

            g.FillPie(Brushes.DarkGray, scaler.Calculate(rect), 270, 180);
            g.DrawArc(mainPen, scaler.Calculate(rect), 270, 180);

            var points = new[]
            {
                new PointModel { X = 3, Y = 6 },
                new PointModel { X = 2.5, Y = 9 },
                new PointModel { X = 4.5, Y = 9 },
                new PointModel { X = 4, Y = 6 },
            };
            var calculatedPoints = points.Select(scaler.Calculate).ToArray();
            g.FillPolygon(Brushes.DarkGray, calculatedPoints);
            g.DrawPolygon(mainPen, calculatedPoints);
        }

        private void PictureForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}