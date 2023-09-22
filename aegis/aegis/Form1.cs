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
            var painter = new Painter();
            painter.Paint(e.Graphics, ClientRectangle);
        }

        private void PictureForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
