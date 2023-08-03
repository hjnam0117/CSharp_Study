using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 3);
            //그리기 함수 사용
            Rectangle rectangle = new Rectangle(150, 80, 200, 200);
            g.DrawRectangle(blackPen, rectangle);
            //라인
            Point pt1 = new Point(150, 80);
            Point pt2 = new Point(350, 280);
            Point pt3 = new Point(350, 80);
            Point pt4 = new Point(150, 280);
            Point pt5 = new Point(250, 0);
            Point[] pt = { pt1, pt3, pt5 };
            g.DrawLine(redPen, pt1, pt2);
            g.DrawLine(redPen, pt3, pt4);
            //원 그리기
            g.DrawEllipse(bluePen, rectangle);
            Brush brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, rectangle);
            //삼각형 그리기
            Brush brush2 = new SolidBrush(Color.Red);
            g.DrawPolygon(redPen, pt);
            g.FillPolygon(brush2, pt);
        }
    }
}
