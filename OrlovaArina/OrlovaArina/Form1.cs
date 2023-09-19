using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrlovaArina
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
            var YellowPen = new Pen(Color.FromArgb(254, 222, 1)); //желтый цвет для треугольника 

            g.FillRectangle(new SolidBrush(Color.FromArgb(224, 18, 29)),
               0, 0, 816, 489); //фулл красный цвет флага(размеры 816 на 489)
            var points = new[]
            {
                new Point(50,30),
                new Point(55,40),
                new Point(40,30),
                new Point(0,0),
            };
            g.FillPolygon(new SolidBrush(Color.FromArgb(254, 222, 1)), points);
            g.DrawPolygon(YellowPen, points);
            
                         // g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 255), 30),
                         //   300, 225, 300, 150);
        }

        
    }
}
