using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, num4;

        private void button8_Click(object sender, EventArgs e)
        {
            textField.Text += '8';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textField.Text += '7';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textField.Text += '6';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textField.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textField.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textField.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textField.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textField.Text += '5';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textField.Text += '9';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string[] data = textField.Text.Split('+');
            num1 = Int32.Parse(data[0]);
            num2 = Int32.Parse(data[1]);
            


            if (data.Length > 2)
            {
                num3 = Int32.Parse(data[2]);
                textField.Text = (num1 + num2 + num3).ToString();
            }
            else
            {
                textField.Text = (num1 + num2 ).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textField.Text += '+';
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textField.Text += '0';
        }
    }
}
