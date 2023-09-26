namespace aegis
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

            g.FillRectangle(Brushes.Green, 50, 100, 200, 300);
            g.DrawRectangle(mainPen, 50, 100, 200, 300);


            g.FillRectangle(Brushes.White, 250, 100, 200, 300);
            g.DrawRectangle(mainPen, 250, 100, 200, 300);


            g.FillRectangle(Brushes.Red, 450, 100, 200, 300);
            g.DrawRectangle(mainPen, 450, 100, 200, 300);

        }


    }
}