using System.Security.Cryptography.X509Certificates;

namespace FunctionGraph
{
    public partial class Form1 : Form
    {
        int scale;
        Graphics graphics;
        Point p0, pLx, pRx, pBy, pTy;
        int w, h;

        public Form1()
        {
            InitializeComponent();
            scale = trackBar1.Value;
            graphics = pGraph.CreateGraphics();
            CalcBasePoints();
            Draw();
        }

        private void CalcBasePoints()
        {
            w = pGraph.Width;
            h = pGraph.Height;

            p0 = new Point(w / 2, h / 2);
            pLx = new Point(0, h / 2);
            pRx = new Point(w, h / 2);
            pTy = new Point(w / 2, 0);
            pBy = new Point(w / 2, h);
        }

        private void chHyper_CheckedChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scale = trackBar1.Value * 20;
            Draw();
        }

        private void Draw()
        {
            graphics.Clear(pGraph.BackColor);
            DrawCoords();
            if (chSquare.Checked) DrawGraph(Brushes.Red, x => x * x, x => true);
            if (chCube.Checked) DrawGraph(Brushes.Blue, x => x * x * x, x => true );
            if (chHyper.Checked) DrawGraph(Brushes.Pink, x => Math.Sqrt(x), x => x >= 0);
        }


        private void DrawGraph(Brush brush, Func<double, double> f, Func<double, bool> odz)
        {
            double maxX = w / 2.0 / scale;
            double maxY = h / 2.0 / scale;
            double dx = 1.0 / scale;
            for (double x = -maxX; x < maxX; x += dx)
            {
                if (!odz(x)) continue;

                double y = f(x);

                if (Math.Abs(y) > maxY) continue;

                Point p = ConvertCoords(x, y);
                graphics.FillEllipse(brush, p.X - 2, p.Y - 2, 4, 4);
            }
        }

        private Point ConvertCoords(double userX, double userY)
        {
            int x = p0.X + (int)(userX * scale);
            int y = p0.Y - (int)(userY * scale);
            return new Point(x, y);
        }

        private void DrawCoords()
        {
            int shift = 10;
            Pen penCoords = new Pen(Color.LightGray, 1);
            graphics.DrawLine(penCoords, pLx, pRx);
            graphics.DrawLine(penCoords, pTy, pBy);
            
            Brush brushCoords = new SolidBrush(penCoords.Color);
            Point p1 = new Point(pRx.X - shift, pRx.Y - shift / 2);
            Point p2 = new Point(pRx.X - shift, pRx.Y + shift / 2);
            Point p3 = new Point(pTy.X - shift / 2, pTy.Y + shift);
            Point p4 = new Point(pTy.X + shift / 2, pTy.Y + shift);
            graphics.FillPolygon(brushCoords, new Point[] { pRx, p1, p2 });
            graphics.FillPolygon(brushCoords, new Point[] { pTy, p3, p4 });

            double maxX = w / 2.0 / scale;
            double maxY = h / 2.0 / scale;

            for (int i = 0; i < maxX; i++)
            {
                int x = scale * i + p0.X;
                int x2 = -scale * i + p0.X;
                Point p5 = new Point(x, p0.Y - shift / 2);
                Point p6 = new Point(x, p0.Y + shift / 2);
                graphics.DrawLine(penCoords, p5, p6);
                graphics.DrawString($"{i}", Font, brushCoords, p6);

                Point p7 = new Point(x2, p0.Y - shift / 2);
                Point p8 = new Point(x2, p0.Y + shift / 2);
                graphics.DrawLine(penCoords, p7, p8);
                graphics.DrawString($"{-i}", Font, brushCoords, p8);
            }
        }
    }
}