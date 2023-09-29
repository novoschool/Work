using System.Drawing;

namespace WinFormsApp1
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

            g.FillRectangle(Brushes.White, 100, 100, 200);
            g.DrawRectangle(mainPen, 100, 100, 200, 200);
           
        }
    }
}