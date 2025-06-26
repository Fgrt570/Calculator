using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        double Number1;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
            
        }
        private void backspace_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void equals1_Click(object sender, EventArgs e)          
        {
            double Number2;
            double Result;

            Number2 = Convert.ToDouble(textBox1.Text);
            if (Number2 == 0)
                MessageBox.Show(("Ошибка : Выражение не обнаружено("), "Ошибка");
            else
            {
                if (Operation == "+")
                {
                    Result = (Number1 + Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
                if (Operation == "-")
                {
                    Result = (Number1 - Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
                if (Operation == "*")
                {

                    {
                        Result = (Number1 * Number2);
                        textBox1.Text = Convert.ToString(Result);
                        Number1 = Result;
                    }
                }
                if (Operation == "/")
                {
                    if (Number2 == 0)
                        MessageBox.Show(("Ошибка : Нельзя делить на нуль"), "Ошибка");
                    else
                    {
                        Result = (Number1 / Number2);
                        textBox1.Text = Convert.ToString(Result);
                        Number1 = Result;
                    }
                }
                if (Operation == "log")
                {
                    Result = Math.Log(Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
                if (Operation == "sqrt")
                {
                    Result = Math.Sqrt(Number1);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Number1 = Convert.ToDouble(textBox1.Text);
            if (Number1 == 0) { MessageBox.Show(("Ошибка : Введите число!"), "Ошибка"); }
      
            else
            {
                textBox1.Text = "0";
                Operation = "/";
            }  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            if (Number1 == 0) { MessageBox.Show(("Ошибка : Введите число!"), "Ошибка"); }
            else
            {                
                textBox1.Text = "0";
                Operation = "*";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            if (Number1 == 0) { MessageBox.Show(("Ошибка : Введите число!"), "Ошибка"); }
            else
            {
            textBox1.Text = "0";
            Operation = "-";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            if (Number1 == 0) { MessageBox.Show(("Ошибка : Введите число!"), "Ошибка"); }
            else
            {
                textBox1.Text = "0";
                Operation = "+";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "log";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "sqrt";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();//Form2 -- вторая форма
            newfrm.Show();
        }
    }
}
