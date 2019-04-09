/*
Задача 3
Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента
Манжай Олег
 */
using System;
using System.Collections.Generic;
using System.IO;


namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakalav = 0;    //количество бакалавров
            int magistr = 0;    //количество магистров  
            int magistr5 = 0;   // количество магистров 5 курса
            int magistr6 = 0;   // количество магичтров 6 курса
            int studentCountAge = 0; // количество студентов в возрасте от 18 до 20 лет
            //Создаем список студентов
            List<Student> list = new List<Student>(); // список объектов Студенты
            DateTime dt = DateTime.Now;
            Student t;     
            StreamReader sr = new StreamReader("student_2.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    //Добавляем в список новый экземляр класса Student

                    t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(t); // заполняем список Студентами

                    //Одновременно подсчитываем кол-во бакалавров и магистров
                    if (t.course < 5) bakalav++; else magistr++;
                    if (t.course == 5) magistr5++;
                    else if (t.course == 6) magistr6++;
                    // считаем количество студентов в возрасте от 18 до 20 лет
                    if (t.age >= 18 && t.age <= 20)
                    {
                        studentCountAge++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();

            Console.WindowWidth = 160;
            Console.BufferWidth = 160;
            //Можно оставить просто MyMethod, но помнить, что мы создаем объект-делегат, который передается в метод Sort
            list.Sort(Student.MyMethod);
            foreach (var v in list) Console.WriteLine($"{v.ToString()}");
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalav);
            Console.WriteLine("Магистров 1 курса :{0}", magistr5);
            Console.WriteLine("Магистров 2 курса :{0}", magistr6);
            Console.WriteLine("Cтуденты от 18 до 20:{0}", studentCountAge);
            Console.WriteLine();
            Console.WriteLine("Cписок по возрасту");
            list.Sort(Student.MyMethod1);
            foreach (var v in list) Console.WriteLine(v);
            Console.WriteLine();
            Console.WriteLine("Список по курсу и возрасту");
            list.Sort(Student.MyMethod2);
            foreach (var v in list) Console.WriteLine(v);
            int course0 = 0, course1 = 0, course2 = 0, course3 = 0, course4 = 0, course5 = 0, course6 = 0; // храним количество студентов на курсе в возрасте от 18 до 20
            for (int i = 0; i < list.Count; i++)
            {
                Student.MyMethod3(list[i], ref course0, ref course1, ref course2, ref course3, ref course4, ref course5, ref course6);
            }

            int[] mass = new int [] {course0,course1,course2, course3,course4,course5,course6};// массив для хранения информации о том сколько студентов учится на курсе 
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"Количество студентов в возрасте от 18 до 20 лет на {i} курсе = {mass[i]}");
            }
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
