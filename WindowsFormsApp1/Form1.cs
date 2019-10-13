using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a, b, c;
            a = Convert.ToDecimal(textBox1.Text);
            b = Convert.ToDecimal(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToInt64(textBox1.Text);
            b = Convert.ToInt64(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}
