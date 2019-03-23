/*5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 * нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        /// <summary>
        /// Находит индекс массы тела 
        /// </summary>
        /// <param name="weigth">вес</param>
        /// <param name="heigth">рост</param>
        /// <returns>индекс</returns>
        static double index(double weigth, double heigth)
        {
            return weigth / Math.Pow(heigth, 2);
        }
        static void Main(string[] args)
        {
            double weigth, heigth, result;

            Console.WriteLine("Программа расчета индекса массы");
            Console.Write("Введите ваш вес: ");
            weigth = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            heigth = double.Parse(Console.ReadLine());
            result = index(weigth, heigth);// индекс массы тела 
            Console.WriteLine($"Ваш индек составляет: {result}");
            /*Шкала индексов*/
            if (result >= 0 && result < 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела, срочно наберите вес");
            }
            else if(result >=16 && result < 18.5)
            {
                Console.WriteLine("Недостаточная масса тела, срочно наберите вес");
            }
            else if (result >= 18.5 && result < 25)
            {
                Console.WriteLine("Норма, вы в прекрасной форме");
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Лишний вес, советую вам похудеь");
            }
            else if (result >= 30 && result < 35)
            {
                Console.WriteLine("Ожирение I cтепени, в зал");
            }
            else if (result >= 35 && result < 40)
            {
                Console.WriteLine("Ожирение II cтепени, в зал срочно");
            }
            else if (result >= 40)
            {
                Console.WriteLine("Ожирение III cтепени, в зал срочно и диета");
            }
            Console.ReadKey();
        }
    }
}
