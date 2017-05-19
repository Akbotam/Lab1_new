using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;

namespace Car
{
    class Car
    {
        public GraphicsPath path3 = new GraphicsPath();

        public Car(int x, int y)
        {
            path3.AddLine(x + 100, y + 80, x + 181, y + 120);
            path3.AddLine(x + 181, y + 120, x + 181, y + 160);
            path3.AddLine(x + 181, y + 160, x + 100, y + 200);
            path3.AddLine(x + 100, y + 200, x + 19, y + 160);
            path3.AddLine(x + 19, y + 160, x + 19, y + 120);
            path3.AddLine(x + 19, y + 120, x + 100, y + 80);
         }

    }
}

   
