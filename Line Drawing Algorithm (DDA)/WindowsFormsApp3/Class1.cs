using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Class1
    {
        public Bitmap bmp;
        public int[] Arr = new int[100000];
        private int round(float a)
        {

            return ((int)(a + 0.5));
        }

        public void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            
            bmp.SetPixel(round(x), round(y), Color.Green);

            Arr[0] = round(x);
            Arr[1] = round(y);
            int j = 2;
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                bmp.SetPixel(round(x), round(y), Color.Green);
                Arr[j++] = round(x);
                Arr[j++] = round(y);
            }
        }
    }
}
