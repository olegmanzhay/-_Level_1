/*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f 
 (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        /// <summary>
        /// Вычисление растояния по двум точкам
        /// </summary>
        static float result(int x1, int y1, int x2, int y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            int x1, y1; // точка 1
            int x2, y2; // точка 2
            float distance;//расстояние между точками

            Console.WriteLine("Введите координаты точки 1 (x,y): ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите координаты точки 2 (x,y): ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            distance = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние = {distance.ToString("#.##")}");
            Console.WriteLine($"Расстояние(метод) = {result(x1, y1, x2, y2).ToString("#.##")}");

            Console.ReadKey();
        }
    }

}
