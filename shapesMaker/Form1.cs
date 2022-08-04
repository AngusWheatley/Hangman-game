using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapesMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);               //Paint the exterior
            Brush brush = new SolidBrush(Color.Red);        //Paint the exterior

            /*
            g.DrawLine(myPen, 2, 2, 400, 450);
            g.DrawRectangle(myPen, 100, 100, 200, 150);
            g.DrawEllipse(myPen, 300, 200, 50, 50);
            g.DrawArc(myPen, 400, 100, 50, 50, 0, 315);
            */

            g.DrawArc(myPen, 100, 100, 250, 250, 0, 360);
            g.DrawArc(myPen, 135, 130, 60, 60, 0, 360);
            g.DrawArc(myPen, 255, 130, 60, 60, 0, 360);
            g.DrawArc(myPen, 150, 180, 160, 130, 0, 180);


            
            String drawString = "yo!";

            Font drawFont = new Font("Jokerman", 24);

            SolidBrush drawBrush = new SolidBrush(Color.Green);

            PointF drawPoint = new PointF(195.0F, 40.0F);

            g.DrawString(drawString, drawFont, drawBrush, drawPoint);


        }
    }
}
