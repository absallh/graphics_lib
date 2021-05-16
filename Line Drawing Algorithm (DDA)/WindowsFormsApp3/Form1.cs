using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var brush = Brushes.Black;
            Class1 DDA = new Class1();
            var p = panel1.CreateGraphics();
            

            DDA.bmp = new Bitmap(panel1.Width, panel1.Height);
            int[] Arr = DDA.Arr;
            DDA.lineDDA(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                p.FillRectangle(brush, Arr[j], Arr[j + 1], 2, 2);
                j = j + 2;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
