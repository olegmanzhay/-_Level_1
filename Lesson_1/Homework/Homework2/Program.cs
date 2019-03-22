/*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
  по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            double index;

            Console.WriteLine("Добрый день! Это программа расчета индекса массы тела");
            Console.Write("Введите ваш вес в кг: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост в метрах: ");
            height = double.Parse(Console.ReadLine());
            index = weight / (Math.Pow(height, 2));
            Console.Write($"Индекс массы вашего тела составляет: {index}");

            Console.ReadKey();
        }
    }
}
