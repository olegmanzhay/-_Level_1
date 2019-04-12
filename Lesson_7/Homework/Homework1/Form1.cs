/*а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
Используйте  библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack
Манжай Олег*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Game2; // библиотека для работы со Stack


namespace Homework1
{
    public partial class Form1 : Form
    {
        Stack<int> Command = new Stack<int>(); // Stack для хранения числа и количества операций
        int k = 0;  // счетчик показываюзий 1 нажатие Отмены
        int d = 0;  // сетчик нажатия Сброса
        public Form1()
        {
            InitializeComponent();    
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCountCommand.Text = (int.Parse(lblCountCommand.Text) + 1).ToString();
            Game.writeStack(Command, lblNumber.Text, lblCountCommand.Text);
            k = 0;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text =(int.Parse(lblNumber.Text) * 2).ToString();
            lblCountCommand.Text = (int.Parse(lblCountCommand.Text) + 1).ToString();
            Game.writeStack(Command, lblNumber.Text, lblCountCommand.Text);
            k = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCountCommand.Text = 0.ToString();
            Game.writeStack(Command, lblNumber.Text, lblCountCommand.Text);
            k = 0;
            d++;
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show($"Вы должны досчитать до {r.Next(0,1001)} за минимальное количество попыток!");
            k = 0;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0 || d > 0)
                {
                    Game.deleteElementStack(Command);
                    k++;
                }
                lblCountCommand.Text = (Command.Pop()).ToString();
                lblNumber.Text = (Command.Pop()).ToString();
                if (d > 0)
                {
                    Game.writeStack(Command, lblNumber.Text, lblCountCommand.Text);
                }
            }
            catch
            {
                MessageBox.Show("Стек пуст");
            }   
        }
    }
}
