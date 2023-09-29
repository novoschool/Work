namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var mainPen = new Pen(Color.Black, 1);

            g.FillRectangle(Brushes.White, 100, 50, 300, 300);
            g.DrawRectangle(mainPen, 100, 50, 150, 150);

            g.FillRectangle(Brushes.Red, 100, 200, 100, 100);
            g.DrawRectangle(mainPen, 100, 200, 100, 100);

        }
    }
}