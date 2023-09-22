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
            var painter = new Painter();
            painter.Paint(e.Graphics, ClientRectangle);
        }

        private void PictureForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}