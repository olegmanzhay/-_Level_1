using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Homework5
{
    public class Student
    {
        string name;
        string surname;
        int course;
        int age;
        public Student()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public Student(string name, string surname, int course, int age)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
            this.age = age;
        }
        public List<Student> SR()
        {
            List<Student> list = new List<Student>();
            using (StreamReader sr = new StreamReader("student.csv"))
            {
                while (!sr.EndOfStream)
                {

                    string[] str = sr.ReadLine().Split(';');
                    Student student = new Student(str[0], str[1], int.Parse(str[2]), int.Parse(str[3]));
                    list.Add(student);
                }
            }
            return list;
        }
        public void ConvetrXML(List<Student> a)
        {

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            xmlFormat.Serialize(System.Xml.XmlWriter.Create("123.xml"), a); // создаем XML - файл и кидаем туда наш список из CSV файла


        }
    }
}
