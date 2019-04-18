/*
** Написать программу-преобразователь из CSV в XML-файл с информацией о студентах
Манжай Олег
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Student s = new Student(); // объект студент
            List<Student> list1 = new List<Student>();//список под студентов
            list1 = s.SR();     // список студентов
            foreach (var i in list1)
            {
                dataStudent.Rows.Add(i.Name, i.Surname, i.Course, i.Age);   // записываем в строку данные о студенте
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            
            string str1 = string.Empty;
            string str2 = string.Empty;
            int str3;
            int str4;
            List<Student> list = new List<Student>();
            for (int i = 0,j=0; i < dataStudent.RowCount-1; i++)
            {
                str1 = dataStudent.Rows[i].Cells[j].Value.ToString();
                j++;
                str2 = dataStudent.Rows[i].Cells[j].Value.ToString();
                j++;
                str3 = int.Parse(dataStudent.Rows[i].Cells[j].Value.ToString());
                j++;
                str4 = int.Parse(dataStudent.Rows[i].Cells[j].Value.ToString());
                j++;
                Student student = new Student(str1, str2, str3, str4);
                list.Add(student);
                j = 0;
            }
            Student b = new Student();
            b.ConvetrXML(list);
            
        }
    }
}
