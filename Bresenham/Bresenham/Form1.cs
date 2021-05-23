using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bresenham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bresenham (int x_start, int y_start, int x_end, int y_end)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            //calculate the constants
            int dx = Math.Abs(x_end - x_start), dy = Math.Abs(y_end - y_start);
            int x, y, p = (2 * dy) - dx;
            int two_dy = (2 * dy), two_dy_minus_dx = (2 * (dy - dx));

            if (x_start > x_end)
            {
                x = x_end;
                y = y_end;
                x_end = x_start;
            }else
            {
                x = x_start;
                y = y_start;
            }

            g.FillRectangle(aBrush, x, y, 1, 1);

            while (x < x_end)
            {
                x++;
                if (p < 0)
                {
                    p += two_dy;
                }
                else
                {
                    y++;
                    p += two_dy_minus_dx;
                }
                g.FillRectangle(aBrush, x, y, 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x_start = Convert.ToInt32(textBox1.Text);
                int y_start = Convert.ToInt32(textBox2.Text);
                int x_end = Convert.ToInt32(textBox3.Text);
                int y_end = Convert.ToInt32(textBox4.Text);

                bresenham(x_start, y_start, x_end, y_end);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You did't enter all text boxs or you didn't enter an int numbers");
            }
        }
    }
}
