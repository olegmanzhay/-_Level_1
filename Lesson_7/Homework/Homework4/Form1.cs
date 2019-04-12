/*Не нашел формулировку задания, но по-моему нужно было реализовать сложение чисел из textbox
Манжай Олег
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework4
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();    // список чисел
            string a = string.Empty;  // число
            string str = textBox1.Text; // выражение
            Sum.SumNumbers(numbers, a, str);
            int superResult = 0;    // результат выражения
            for (int i = 0; i < numbers.Count; i++)
            {

                superResult += numbers[i];
            }
            textBox1.Text = superResult.ToString();
        }
    }
}
