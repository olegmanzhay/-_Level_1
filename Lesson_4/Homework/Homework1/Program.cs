using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    { 
        static void Main(string[] args)
        {
            const int n = 20; // количество элементов массива
            int[] arr = new int[n];
            Random r = new Random(); //генератор случайных чисел

            using (StreamWriter sw = new StreamWriter("file1.txt")) // записан массив в файл
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(-10001, 10001);
                    if (i != arr.Length - 1)
                        sw.Write($"{arr[i]} ");
                    else
                        sw.Write($"{arr[i]}");
                }
            }
            int[] mass = StaticClass.Reader();// чтение из файла в массив -> StaticClass
            Console.WriteLine("Программа сгенерировала массив чисел\n");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nКоличество пар составляет: {StaticClass.para(arr)}"); // метод нахождения пар -> StaticClass
            Console.ReadKey();
            
        }
    }
}
