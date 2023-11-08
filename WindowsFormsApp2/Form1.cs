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
            Double x, y, r;
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out r))
            {
                if (x >= -7 && x <= -3)
                {
                    y = 3;
                    label3.Text = "y = " + y.ToString();
                }
                else if (x <= 0)
                {
                    y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 3;
                    label3.Text = "y = " + Convert.ToString(-y);
                }
                else if (x <= 3)
                {
                    y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 3;
                    label3.Text = "y = " + Convert.ToString(-y);
                }
                else if (x <= 6)
                {
                    y = -2 * x + 9;
                    label3.Text = "y = " + y.ToString();
                }
                else if (x <= 11)
                {
                    y = x - 9;
                   
                    label3.Text = "y = " + y.ToString();
                }
                else
                {
                    MessageBox.Show("Вы указали недействительное значение Х");
                }
            }
            else
            {
                MessageBox.Show("Вы указали недопустимые значения x или r");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
