using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPPTObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> ListPoint = new List<Point>();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics ;
            Pen myPen = new Pen(Color.Black,8);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawRectangle(myPen ,rect );
            g.FillRectangle(Brushes .YellowGreen,rect );
            
            for(int i = 0;ListPoint .Count >=2;i++)
            {
                g.DrawEllipse (myPen ,lstRect [i]);
                //g.FillEllipse (Brushes ,);
            }
                
            //g.DrawEllipse (myPen, x, y, w, h);
            //g.FillEllipse (Brushes.YellowGreen, x, y, w, h);
        }
        List <Rectangle >lstRect = new List<Rectangle > ();
        Rectangle rect = new Rectangle();
        int congx = 0;
        bool isDrawing;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rect.Location = e.Location;
            isDrawing = true; 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left||isDrawing ==true )
            {
                rect .Width = e.X - rect .X ;
                rect .Height = e.Y - rect .Y ;
                
                this.Invalidate();
                ListPoint.Add(e.Location);
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            lstRect.Add(rect);
        }
    }
}
