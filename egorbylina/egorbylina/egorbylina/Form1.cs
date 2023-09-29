using PictureApp;

namespace egorbylina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var painter = new Painter();
            painter.Paint(e.Graphics, ClientRectangle);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}