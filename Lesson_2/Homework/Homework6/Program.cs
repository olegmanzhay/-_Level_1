/**Написа ть программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, 
 * которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        /// <summary>
        /// Проверяет хорошие числа
        /// </summary>
        /// <param name="i">начало диапазона</param>
        /// <returns>Возврашает хорошее число</returns>
        static bool CheckNumber(int i)
        {
            int k = i;
            int sumNumber = 0;
            while (k > 0)
            {
                sumNumber += k % 10;
               k /= 10;
            }
            return i % sumNumber == 0;

        }
        /// <summary>
        /// Выводит сумму "Хороших чисел"
        /// </summary>
        /// <param name="a">Начало диапазона</param>
        /// <param name="b">Конец диапазона</param>
        /// <returns>Сумма хороших чисел</returns>
        static int GoodNumbers(string a, string b)
        {
            
            int iterator =0;
            bool flag = false;
            for (int i = int.Parse(a); i < int.Parse(b); i++)
            {
                flag = CheckNumber(i);
                if (flag == true)
                {
                    iterator++;
                    
                }
            }
            return iterator;
        }
        static void Main(string[] args)
        {
            string number1 = "1", number2 = "13";
            Console.WriteLine($"Количество хороших чисел составляет : {GoodNumbers(number1, number2)}");
            Console.ReadKey();

           
        }
    }
}
