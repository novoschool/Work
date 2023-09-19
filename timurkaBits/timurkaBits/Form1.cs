namespace timurkaBits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {



            var g = CreateGraphics();


            var clientRect = ClientRectangle;
            clientRect.Inflate(1, 1);
            var greenPen = new Pen(Color.Green, 3);
            g.DrawRectangle(greenPen, clientRect);
            g.DrawRectangle(greenPen, clientRect);
            g.DrawRectangle(greenPen, clientRect);


            g.FillRectangle(new SolidBrush(Color.FromArgb(82, 71, 58)),
                100, 200, 400, 200);
            g.DrawRectangle(new Pen(Color.FromArgb(32, 18, 12), 5),
                 100, 200, 400, 200);
            g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 12), 5),
                 120, 250, 100, 100);
            g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 12), 5),
                 120, 250, 200, 100);
            g.DrawRectangle(new Pen(Color.FromArgb(153, 151, 147), 5),
                 120, 250, 300, 100);
            g.FillRectangle(new SolidBrush(Color.FromArgb(130, 174, 179)),
                 120, 250, 300, 100);
            g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 12), 5),
                 120, 250, 370, 80);
            g.FillRectangle(new SolidBrush(Color.FromArgb(34, 205, 224)),
                 120, 250, 370, 80);
            g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 12), 5),
                 120, 250, 370, 20);
            g.FillRectangle(new SolidBrush(Color.FromArgb(34, 205, 224)),
                 120, 250, 370, 20);
            g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 12), 5),
                 120, 250, 370, 100);
            g.FillRectangle(new SolidBrush(Color.FromArgb(34, 205, 224)),
                120, 250, 370, 20);
            g.DrawLine(new Pen(Color.Green, 7),
                100, 200, 300, 100);
            g.DrawLine(new Pen(Color.Green, 7),
                300, 200, 300, 100);
            g.DrawLine(new Pen(Color.Green, 7),
               500, 200, 300, 100);
            g.DrawEllipse(new Pen(Color.White, 7),
                 260, 100, 80, 80);
            g.FillEllipse(new SolidBrush(Color.Aqua),
              260, 100, 80, 80);
            g.DrawRectangle(new Pen(Color.FromArgb(209, 130, 2), 5),
                 0, 200, 100, 200);
            g.FillRectangle(new SolidBrush(Color.FromArgb(209, 130, 2)),
                0, 200, 100, 200);
            g.DrawEllipse(new Pen(Color.Aqua),
                 40, 220, 20, 20);
            g.FillEllipse(new SolidBrush(Color.Aqua),
               40, 220, 20, 20);
            g.DrawEllipse(new Pen(Color.Black),
                 70, 300, 10, 10);
            g.FillEllipse(new SolidBrush(Color.Black),
               70, 300, 10, 10);
            g.DrawLine(new Pen(Color.Green, 7),
               600, 600, 600, 300);
            g.DrawEllipse(new Pen(Color.Yellow, 7),
               550, 200, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Yellow),
                550, 200, 100, 100);
            g.DrawEllipse(new Pen(Color.Yellow, 7),
               650, 20, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Yellow),
                 650, 20, 100, 100);




        }
    }
}