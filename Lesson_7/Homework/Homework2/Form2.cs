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
    public partial class Form2 : Form
    {
        int number;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(0, 101);
            //MessageBox.Show(number.ToString());
            btnNumber.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int str = int.Parse(textBox1.Text);
            if(str > number)
            {
                MessageBox.Show("Меньше");
            }
            else if (str < number)
            {
                MessageBox.Show("Больше");
     
            }
            else
            {
                MessageBox.Show("Угадал число");
                btnNumber.Enabled = true;
                textBox1.Text = string.Empty;
            }
        }
    }
}
