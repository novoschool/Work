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
                Y = 9,
                Width = 3,
                Height = -7,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -6.5,
                Y = 8,
                Width = 1,
                Height = -2,
            };

            g.FillRectangle(Brushes.Azure, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            rect = new RectangleModel
            {
                X = -5,
                Y = 6,
                Width = 11,
                Height = -4,
            };

            g.FillRectangle(Brushes.DarkGray, scaler.Calculate(rect));
            g.DrawRectangle(mainPen, scaler.Calculate(rect));

            g.FillEllipse(Brushes.DarkGray, 150, 400, 150, 150);
            g.DrawEllipse(mainPen, 150, 400, 150, 150);

            g.FillEllipse(Brushes.DarkGray, 350, 400, 150, 150);
            g.DrawEllipse(mainPen, 350, 400, 150, 150);

            g.FillEllipse(Brushes.DarkGray, 550, 400, 150, 150);
            g.DrawEllipse(mainPen, 550, 400, 150, 150);

            g.FillEllipse(Brushes.DarkGray, 750, 400, 150, 150);
            g.DrawEllipse(mainPen, 750, 400, 150, 150);

            g.FillPie(Brushes.DarkGray, 800, 200, 200, 200, 270, 180);
            g.DrawArc(mainPen, 800, 200, 200, 200, 270, 180);

            var points = new[]
            {
                new Point(800, 200),
                new Point(780, 100),
                new Point(870, 100),
                new Point(850, 200),
            };
            g.FillPolygon(Brushes.DarkGray, points);
            g.DrawPolygon(mainPen, points);
        }

        private void PictureForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}