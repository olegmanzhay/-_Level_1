/*Задача 1
С помощью рефлексии выведите все свойства структуры DateTime
Манжай Олег
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Homework1
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
        class A
        {
            public int Button;
            public string GetButtonValue(string text)
            {
                string a = string.Empty;
                a = $"{text} {this.Button}";
                return a;
            }
        }
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        private void btnDateTime_Click_1(object sender, EventArgs e)
        {
            string str = string.Empty;
            DateTime dateTime = new DateTime();
            Type t = dateTime.GetType();
            PropertyInfo[] pi = t.GetProperties();
            MethodInfo[] me = t.GetMethods();
            rtxtDateTime.Text += "\n_________________________Свойства____________________________\n\n";
            for (int i = 0; i < pi.Length; i++)
            {
                rtxtDateTime.Text += $"{pi[i].ToString()}\n";
            }
            rtxtDateTime.Text += "\n__________________________Методы____________________________\n\n";
            for (int i = 0; i < me.Length; i++)
            {
                rtxtDateTime.Text += $"{me[i].ToString()}\n";
            }


            //rtxtDateTime.Text += (GetPropertyInfo(dateTime, "DayOfWeek").CanRead).ToString();
            //rtxtDateTime.Text += (GetPropertyInfo(dateTime, "DayOfWeek").CanWrite).ToString();
            //rtxtDateTime.Text += (GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null)).ToString();

        }
    }
}
