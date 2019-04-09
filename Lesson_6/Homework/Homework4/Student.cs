using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string univercity;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        //Создаем конструктор
        public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        public override string ToString()
        {
            return string.Format("{0,15}{1,15}{2,15}{3,20}{4,20}{5,5}{6,10}{7,9}{8,20}", firstName, lastName, univercity, faculty, department, age, course, group, city);
        }

        public static int MyMethod(Student st1, Student st2)//Создаем метод для сравнения для экземпляров
        {
            //Сравниваем две строки
            return String.Compare(st1.firstName, st2.firstName);
        }
        public static int MyMethod1(Student st1, Student st2)//Создаем метод для сравнения для экземпляров
        {
            //Сравниваем две строки
            if (st1.age > st2.age) return 1;
            if (st1.age < st2.age) return -1;
            return 0;

        }
        public static int MyMethod2(Student st1, Student st2)//Создаем метод для сравнения для экземпляров
        {
            int ires = 0;
            if (st1.course > st2.course)
            {
                ires = 1;
            }
            else if (st1.course < st2.course)
            {
                ires = -1;
            }
            else if (st1.course == st2.course)
            {
                if (st1.age > st2.age)
                    return 1;
                else
                    return -1;
            }

            return ires;
        }
        public static void MyMethod3(Student a, ref int course0, ref int course1, ref int course2, ref int course3, ref int course4, ref int course5, ref int course6)
        {
            if (a.course == 0)
            {
                if (a.age >= 18 && a.age <= 20)
                    course0++;
            }
            else if (a.course == 1)
            {
                if (a.age >= 18 && a.age <= 20)
                    course1++;
            }
            else if (a.course == 2)
            {
                if (a.age >= 18 && a.age <= 20)
                    course2++;
            }
            else if (a.course == 3)
            {
                if (a.age >= 18 && a.age <= 20)
                    course3++;
            }
            else if (a.course == 4)
            {
                if (a.age >= 18 && a.age <= 20)
                    course4++;
            }
            else if (a.course == 5)
            {
                if (a.age >= 18 && a.age <= 20)
                    course5++;
            }
            else if (a.course == 6)
            {
                if (a.age >= 18 && a.age <= 20)
                    course6++;
            }
        }

        static void H<T>(T a)
        {
            Console.WriteLine(a.ToString());
        }
    }
}