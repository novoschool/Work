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

            g.FillRectangle(Brushes.DarkGray, 100, 100, 200, 300);
            g.DrawRectangle(mainPen, 100, 100, 200, 300);

            g.FillRectangle(Brushes.Azure, 200, 120, 80, 120);
            g.DrawRectangle(mainPen, 200, 120, 80, 120);

            g.FillRectangle(Brushes.DarkGray, 300, 200, 600, 200);
            g.DrawRectangle(mainPen, 300, 200, 600, 200);

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
    }
}