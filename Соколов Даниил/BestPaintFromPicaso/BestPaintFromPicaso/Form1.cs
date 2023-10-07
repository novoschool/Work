namespace BestPaintFromPicaso
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPaint_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            var Black = new Pen(Color.Black);

            g.FillRectangle(new SolidBrush(Color.FromArgb(0,0,0)), 100, 100, 400, 200);
            Point[] points = new Point[3];
            points[0] = new Point(100, 100);
            points[1] = new Point(500, 100);
            points[2] = new Point(100, 300);
            g.FillPolygon(new SolidBrush(Color.Red), points);
            

        }
    }
}