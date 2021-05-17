using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dda (int x_start, int y_start, int x_end, int y_end)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            int dx = x_end - x_start, dy = y_end - y_start, steps;
            float x_increment, y_increment, x = x_start, y = y_start;

            steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            x_increment = (float)dx / (float)steps;
            y_increment = (float)dy / (float)steps;

            g.FillRectangle(aBrush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);
            Debug.WriteLine("x=" + x + "\t" + "y=" + y);
            for (int k = 0; k < steps; k++)
            {
                x += x_increment;
                y += y_increment;
                g.FillRectangle(aBrush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y);
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

                dda(x_start, y_start, x_end, y_end);   
            }
            catch (Exception)
            {
                MessageBox.Show("You did't enter all text boxs or you didn't enter an int numbers");
            }
        }
    }
}
