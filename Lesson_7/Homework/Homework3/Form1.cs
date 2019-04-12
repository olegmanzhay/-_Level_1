/*Ковер Серпинского
 Манжай Олег*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random r;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            x = x1;
            y = y1;
            r = new Random();
            brush = new SolidBrush(Color.Black);
        }
        int x1 = 0, y1 = 0;
        int x2 = 200, y2 = 0;
        int x12 = 100, y12 = 0;
        int x3 = 0, y3 = 200;
        int x4 = 200, y4 = 200;
        int x34 = 100, y34 =200;
        int x13 = 0, y13 = 100;
        int x24 = 200, y24 = 100;
        int x, y;

        void MovePrint(int GetX, int GetY, ref int X, ref int Y)
        {
            X = (X + 2*GetX) / 3;
            Y = (Y + 2*GetY) / 3;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {


                switch (r.Next(8))
                {
                    case 0: MovePrint(x1, y1, ref x, ref y); break;
                    case 1: MovePrint(x12, y12, ref x, ref y); break;
                    case 2: MovePrint(x2, y2, ref x, ref y); break;
                    case 3: MovePrint(x24, y24, ref x, ref y); break;
                    case 4: MovePrint(x4, y4, ref x, ref y); break;
                    case 5: MovePrint(x34, y34, ref x, ref y); break;
                    case 6: MovePrint(x3, y3, ref x, ref y); break;
                    default: MovePrint(x13, y13, ref x, ref y); break;
                }
                g.FillEllipse(brush, x, y, 2, 2);
            }
        }
    }
}
