using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "+";
            try
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch(FormatException)
            {
                textBox1.Text = "Error! Non numeric value is entered";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "-";
            try
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (FormatException)
            {
                textBox1.Text = "Error! Non numeric value is entered";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "*";
            try
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (FormatException)
            {
                textBox1.Text = "Error! Non numeric value is entered";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            option = "/";
            try
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
            catch (FormatException)
            {
                textBox1.Text = "Error! Non numeric value is entered";
            };
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = int.Parse(textBox1.Text);

                if (option.Equals("+"))
                {
                    result = num1 + num2;
                }
                if (option.Equals("-"))
                {
                    result = num1 - num2;
                }
                if (option.Equals("*"))
                {
                    result = num1 * num2;
                }
                if (option.Equals("/"))
                {
                    try
                    {
                        result = num1 / num2;
                    }
                    catch (DivideByZeroException)
                    {
                        textBox1.Text = "Error! Divide by zero exception";
                    }

                }
            }
            catch (FormatException)
            {
                textBox1.Text = "Error! Non numberc value is entered";
            }


            textBox1.Text = result + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

