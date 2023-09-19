﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //g.FillRectangle(Brushes.Azure, 200, 120, 80, 120);
            //g.DrawRectangle(mainPen, 200, 120, 80, 120);

            //g.FillRectangle(Brushes.DarkGray, 300, 200, 600, 200);
            //g.DrawRectangle(mainPen, 300, 200, 600, 200);

            //g.FillRectangle(Brushes.DarkGray, 600, 200, 600, 200);
            //g.DrawRectangle(mainPen, 600, 200, 600, 200);


            g.FillRectangle(Brushes.White, 250, 100, 200, 300);
            g.DrawRectangle(mainPen, 250, 100, 200, 300);

            g.FillRectangle(Brushes.Red, 400, 100, 200, 300);
            g.DrawRectangle(mainPen, 400, 100, 200, 300);





        }
    }
}
