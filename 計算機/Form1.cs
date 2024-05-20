using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class 簡易兩數運算計算機 : Form
    {
        public 簡易兩數運算計算機()
        {
            InitializeComponent();
        }
        char oper;
        double num1;
        double num2;
        double result;
        private void button0_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if(顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (顯示.Text == "0")
            {
                顯示.Text = a.Text;
            }
            else
            {
                顯示.Text += a.Text;
            }
            過程.Text += a.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (顯示.Text != "")
            {
                顯示.Text += ".";
                過程.Text += ".";
            }
            else
            {
                顯示.Text = "0.";
                過程.Text += "0.";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(顯示.Text != "")
            {
                num1 = double.Parse(顯示.Text);
                oper = char.Parse(((Button)sender).Text);
                顯示.Text = "";
                過程.Text += " / ";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (顯示.Text != "")
            {
                num1 = double.Parse(顯示.Text);
                oper = char.Parse(((Button)sender).Text);
                顯示.Text = "";
                過程.Text += " * ";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (顯示.Text != "")
            {
                num1 = double.Parse(顯示.Text);
                oper = char.Parse(((Button)sender).Text);
                顯示.Text = "";
                過程.Text += " - ";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (顯示.Text != "")
            {
                num1 = double.Parse(顯示.Text);
                oper = char.Parse(((Button)sender).Text);
                顯示.Text = "";
                過程.Text += " + ";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(顯示.Text != "")
            {
                num2 = double.Parse(顯示.Text);
                switch (oper)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/': if(num2 == 0)
                        {
                            MessageBox.Show("0不能為除數!");
                            break;
                        }
                        result = num1 / num2; break;

                }
                顯示.Text = result.ToString();
            }
            過程.Text += " = "+ result;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            顯示.Text = "";
            過程.Text = "";
            顯示.Focus();
            num1 = 0;
            num2 = 0;
            oper = ' ';
        }
    }
}
