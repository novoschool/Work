using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return;
            }
            
              using (var g = CreateGraphics())
            {
                g.DrawRectangle(Pens.Blue, e.X - 10, e.Y - 10, 20, 20);
            }
           
            
        }

        private void MouseEventsForm_MouseMove(object sender, MouseEventArgs e)
        {
            using (var g = CreateGraphics())
            {
                g.DrawLine(Pens.Black, e.X - 10, e.Y, e.X + 10, e.Y);
                g.DrawLine(Pens.Black, e.X, e.Y - 10, e.X, e.Y + 10);
            }
              
            
        }







    }
}
