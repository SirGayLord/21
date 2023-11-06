using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            double y;

            double x = Double.Parse(textBox1.Text);

            if (x >= -4 && x <= 0)
            {
                y = -x * 0.5;
                label3.Text = "y = " + y.ToString();
            } else if (x <= 2)
            {
                double r = Double.Parse(textBox2.Text);
                y = -(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 2);
                //y = Math.Sqrt(-Math.Pow(x, 2) + 2*x*0 -Math.Pow(0, 2) - Math.Pow(2, 2) + 2*y*2 -Math.Pow(2, 2));
                label3.Text = "y = " + y.ToString();
            } else if (x <= 4)
            {
                double r = Double.Parse(textBox2.Text);
                y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x-2, 2));
                label3.Text = "y = " + Convert.ToString(y);
            } else if (x <= 5)
            {
                y = -x + 4;
                label3.Text = "y = " + y.ToString();
            } else
            {
                MessageBox.Show("Вы указали не действительное значение Х");
            }
            //r2=(x-x0)2+(y-y0)2
        }
    }
} 
