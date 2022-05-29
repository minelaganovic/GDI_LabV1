using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILabVezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            Int32.TryParse(textBox1.Text, out temp);
            Graphics g = CreateGraphics();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Unesite temperaturu");
            }
            else
            {
                if (temp > 15)
                {
                    Pen pen = new Pen(Color.Red, 42);
                    SolidBrush bru = new SolidBrush(Color.Red);
                    Rectangle rect4 = new Rectangle(209, 110, 43, 317);
                    g.FillRectangle(bru, rect4);
                    Graphics g1 = panel1.CreateGraphics();
                    Bitmap bitmap1 = new Bitmap(Properties.Resources.Sun);
                    g1.DrawImage(bitmap1, 100, 20, 100, 100);
                }
                if (temp > 0 && temp < 15)
                {
                    Pen pen = new Pen(Color.Red, 42);
                    Pen pen2 = new Pen(Color.Black, 3);
                    SolidBrush bru = new SolidBrush(Color.Red);
                    Rectangle rect4 = new Rectangle(209, 190, 43, 217);
                    g.FillRectangle(bru, rect4);
                    Graphics g1 = panel2.CreateGraphics();
                    Pen pn = new Pen(Color.Red, 5);
                    Rectangle rect = new Rectangle(10, 50, 50, 50);
                    g1.DrawArc(pen2, rect, 60, 180);
                    Point point1 = new Point(45, 98);
                    Point point2 = new Point(120, 98);
                    Point[] Points = { point1, point2 };
                    g1.DrawCurve(pen2, Points);
                    Rectangle rect3 = new Rectangle(98, 50, 50, 50);
                    g1.DrawArc(pen2, rect3, -95, 200);
                    Rectangle rect5 = new Rectangle(15, 40, 50, 50);
                    g1.DrawArc(pen2, rect5, -180, 140);
                    Rectangle rect6 = new Rectangle(60, 20, 60, 60);
                    g1.DrawArc(pen2, rect6, -180, 190);
                }
               if (temp <= 0)
                {
                    SolidBrush bru = new SolidBrush(Color.Red);
                    Rectangle rect4 = new Rectangle(209, 330, 43, 75);
                    g.FillRectangle(bru, rect4);
                    Graphics g1 = panel3.CreateGraphics();

                    float[] dashValues = { 5, 2, 5, 2 };
                    Pen blackPen = new Pen(Color.Black, 5);
                    blackPen.DashPattern = dashValues;
                    g1.DrawLine(blackPen, new Point(25, 5), new Point(0, 100));
                    g1.DrawLine(blackPen, new Point(45, 5), new Point(20, 100));
                    g1.DrawLine(blackPen, new Point(75, 5), new Point(50, 100));
                    g1.DrawLine(blackPen, new Point(95, 5), new Point(70, 100));
                    g1.DrawLine(blackPen, new Point(115, 5), new Point(90, 100));

                }

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(80, 10, 290, 490);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect,
            Color.White, Color.Gray, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
            Rectangle rect2 = new Rectangle(120, 60, 220, 400);
            LinearGradientBrush lBrush1 = new LinearGradientBrush(rect, Color.DarkGray, Color.White, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush1, rect2);

            Font fnt = new Font("Times New Roman", 25);
            g.DrawString(" C°", fnt, new SolidBrush(Color.Red), 140, 420);
            Font fnt1 = new Font("Times New Roman", 25);
            g.DrawString(" F°", fnt1, new SolidBrush(Color.Red), 260, 420);

            SolidBrush brush = new SolidBrush(Color.Red);
            Rectangle rect3 = new Rectangle(207, 390, 49, 49);
            Pen pn = new Pen(Color.Black, 3);
            Rectangle rec = new Rectangle(207, 390, 49, 49);
            g.DrawEllipse(pn, rec);
            g.FillEllipse(brush, rect3);

            SolidBrush bru = new SolidBrush(Color.LightGray);
            Rectangle rect4 = new Rectangle(209, 100, 44, 300);
            Pen pnnn = new Pen(Color.Black, 2);
            Rectangle reccc = new Rectangle(209, 100, 45, 300);
            g.DrawRectangle(pnnn, reccc);
            g.FillRectangle(bru, rect4);

            Font fnt2 = new Font("Times New Roman", 16);
            SolidBrush bru2 = new SolidBrush(Color.Blue);
            Rectangle podeok = new Rectangle(175, 110, 30, 3);
            g.FillRectangle(bru2, podeok);
            g.DrawString(" 40°", fnt2, new SolidBrush(Color.Black), 130, 102);
            Rectangle podeok100 = new Rectangle(257, 110, 30, 3);
            g.FillRectangle(bru2, podeok100);
            g.DrawString(" 100°", fnt2, new SolidBrush(Color.Black), 275, 98);

            Rectangle podeook20 = new Rectangle(257, 185, 30, 3);
            g.FillRectangle(bru2, podeook20);
            g.DrawString(" 60°", fnt2, new SolidBrush(Color.Black), 279, 172);
            Rectangle podeook10 = new Rectangle(177, 185, 30, 3);
            g.FillRectangle(bru2, podeook10);
            g.DrawString(" 10°", fnt2, new SolidBrush(Color.Black), 140, 172);

            Rectangle podeok40 = new Rectangle(257, 256, 30, 3);
            g.FillRectangle(bru2, podeok40);
            g.DrawString(" 40°", fnt2, new SolidBrush(Color.Black), 279, 246);
            Rectangle podeok0 = new Rectangle(177, 256, 30, 3);
            g.FillRectangle(bru2, podeok0);
            g.DrawString(" 0°", fnt2, new SolidBrush(Color.Black), 140, 248);
            Rectangle podeok10 = new Rectangle(177, 325, 30, 3);
            g.FillRectangle(bru2, podeok10);
            Rectangle podeok6 = new Rectangle(257, 390, 30, 3);
            g.FillRectangle(bru2, podeok6);
            g.DrawString(" -10°", fnt2, new SolidBrush(Color.Black), 125, 318);
            Rectangle podeok20 = new Rectangle(257, 325, 30, 3);
            g.FillRectangle(bru2, podeok20);
            g.DrawString(" 20°", fnt2, new SolidBrush(Color.Black), 279, 318);
            g.DrawString(" 0°", fnt2, new SolidBrush(Color.Black), 281, 380);
            Rectangle podeok7 = new Rectangle(175, 395, 30, 3);
            g.FillRectangle(bru2, podeok7);
            g.DrawString(" -20°", fnt2, new SolidBrush(Color.Black), 125, 385);
            g.TranslateTransform(80, 20);

            for (int j = 0; j < 2; j++)
            {
                SolidBrush br = new SolidBrush(Color.Green);
                for (int i = 0; i < 260; i += 14)
                {

                    Rectangle podeokm = new Rectangle(106, 110 + i, 20, 2);
                    g.FillRectangle(br, podeokm);
                }
                g.TranslateTransform(72, 0);
            }

        }

    }
}
