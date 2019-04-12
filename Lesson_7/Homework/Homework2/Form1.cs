/*Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
 * а человек пытается его угадать за минимальное число попыток.
 * Компьютер говорит, больше или меньше загаданное число введенного.
a) Для ввода данных от человека используется элемент TextBox;
б) ** Реализовать отдельную форму c TextBox для ввода числа.
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startGame.BackgroundImage = Image.FromFile(@"123.jpg");
            startGame.BackgroundImageLayout = ImageLayout.Center;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
