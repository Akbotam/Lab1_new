using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Pen pen;
        Graphics g;
        SolidBrush brush1;
        Car c;
        PictureBox picture;
        Bitmap btm;
        int x, y, l, h, r;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 10;
            if (x >= 938)
            {
                x = 0;
            }
            pictureBox1.Refresh();
        }

        public Form1()
        {
            x = 50;
            y = 50;
            l = 100;
            h = 30;

            InitializeComponent();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush1 = new SolidBrush(Color.Red);
            c = new Car(100, 100);
            g = Graphics.FromImage(btm);
           // btm = new Bitmap(@"C:\Users\Андрей\Desktop\Professional English (B2)\bitmapfon.jpg");
            pictureBox1.Image = btm;
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //g.DrawPath(new Pen(Color.Black), c.path3);
            //g.FillPath(brush1, c.path3);

            g.DrawPath(new Pen(Color.Black), c.path3);
            g.FillPath(brush1, c.path3);
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Red), x + l / 3, y, l / 3, h);
            //e.Graphics.DrawRectangle(new Pen(Color.Green), x, y + h, l, h);
            //e.Graphics.FillEllipse(Brushes.Black, x + l / 3, y + 2 * h, 10, 10);
            //e.Graphics.FillEllipse(Brushes.Black, x + l * 2 / 3, y + 2 * h, 10, 10);
        }
    }
}
