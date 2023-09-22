using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydraw
{
    public partial class Form1 : Form
    {
        private void Form1(PaintEventArgs e) {
            Pen blackpen = new Pen(Brushes.Black);
            blackpen.Width = 8.0F;
            blackpen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            e.Graphics.DrawRectangle(blackpen,
                new Rectangle(40, 40, 150, 200));
                }
    }
}
