//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Манжай Олег
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result=0;
            Console.WriteLine("Здравствуйте, это программа подсчитывает сумму всех нечентных положительных чисел");
            do
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());
                if (number%2 != 0 && number>0)
                {
                    result += number;
                }

            } while (number != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел равна: {result}");

            Console.ReadKey();
        }
    }
}
