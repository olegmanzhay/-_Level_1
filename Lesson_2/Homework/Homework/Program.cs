/*1. Написать метод, возвращающий минимальное из трех чисел.
 Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        /// <summary>
        /// Поиск минимального значения из 3 элементов
        /// </summary>
        /// <param name="x">Первое значение</param>
        /// <param name="y">Второе значение</param>
        /// <param name="z">Третье значение</param>
        /// <returns>Выводит минимальное значение</returns>
        static int minNumber(int x, int y, int z)
        {
            int minValue;
            if (x < y)
            {
                minValue = x;
            }
            else
            {
                minValue = y;
            }

            if (z < minValue)
            {
                minValue = z;
            }

            return minValue;
        }
        static void Main(string[] args)
        {
            string a, b, c;
            int A, B, C;
            Console.WriteLine("Добрый день! Это программа поиска минимального значения из 3 чисел");
            do {
                Console.Write("Введите a: ");
                a = (Console.ReadLine());
            }while(!int.TryParse(a, out A));// пока не введется значение Int32
            do
            {
                Console.Write("Введите b: ");
                b = (Console.ReadLine());
            } while (!int.TryParse(b, out B));
            do
            {
                Console.Write("Введите c: ");
                c = (Console.ReadLine());
            } while (!int.TryParse(c, out C));

            if (A == B && B == C)
            {
                Console.WriteLine("Все числа равны");
            }
            else
            {
                Console.WriteLine($"Минимальное значение составляет: {minNumber(A, B, C)}");
            }

             Console.ReadKey();
        }
    }
}
