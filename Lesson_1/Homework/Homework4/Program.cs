using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c;
            Console.WriteLine($"Начальные значения: a = {a}, b = {b}");
            c = b;
            b = a;
            a = c;
            Console.WriteLine($"Финальные значения: a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Опять начальные значения: a = {a}, b = {b}");

            Console.ReadKey();
        }
    }

}
