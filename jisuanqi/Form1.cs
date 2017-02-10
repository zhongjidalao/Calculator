using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jisuanqi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;

        private void button1_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "1";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if(num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "2";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "3";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "4";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "5";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "6";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "7";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "8";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "9";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                textBox1.Text = " ";
                equal = false;
            }
            textBox1.Text += "0";
            if (textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else if (num2 != 0)
            {
                textBox1.Text = "";
                num2 = 0;
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0.";
            else if (textBox1.Text.IndexOf(".") >= 0)
                MessageBox.Show("已经添加了小数点！", "提示");
            else
                textBox1.Text = textBox1.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt16(textBox1.Text);
            switch (op)
            {
                case 1:
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case 2:
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case 3:
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case 4:
                    textBox1.Text = Convert.ToString(num1 / num2);
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        public bool equal { get; set; }

        public int op { get; set; }

        public double num1 { get; set; }

        public double num2 { get; set; }

        private void button18_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }
    }
}
