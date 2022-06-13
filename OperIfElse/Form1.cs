using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a, b, c, d;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);

            if (a > c & b > d)
            {
                listBox1.Items.Add("поместится");

            }
            else
            {
                listBox1.Items.Add("не поместится ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, q, w, r, qwr, yx;
            q = Convert.ToDouble(textBox5.Text);
            w = Convert.ToDouble(textBox6.Text);
            r = Convert.ToDouble(textBox7.Text);
            x = Convert.ToDouble(textBox8.Text);
            y = Convert.ToDouble(textBox9.Text);
            qwr = q * w * r;
            yx = x * y;
            if(qwr < yx)
            {
                listBox2.Items.Add("пройдёт");
            }
            else
            {
                listBox2.Items.Add("не пройдёт");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m, n, b, v;
            m = Convert.ToDouble(textBox10.Text);
            n = Convert.ToDouble(textBox11);
            b = Convert.ToDouble(textBox12);
            
        }

    
    }
}