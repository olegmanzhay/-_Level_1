/*2. Написать метод подсчета количества цифр числа.
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
        /// <summary>
        /// Находит количество цифр в числе
        /// </summary>
        /// <param name="figure">принямает на вход строку</param>
        /// <returns>количество цифр</returns>
        static int countDigits(string figure)
        {
            int count = 0; // счетчик цифр 
            int notCount = 0;// счетчик не цифр
            for (int i = 0; i < figure.Length; i++)
            {
                if (figure[i] >= 41 && figure[i] <= 57)//Если выпадает цифра -  увеличиваем счетчик (Таблица ASCII)
                {
                    switch (figure[i])
                    {
                        case (char)44://Если выпадает ',' - не будет увеличиваться счетчик цифр
                            break;
                        case (char)45://Если выпадает '-' - не будет увеличиваться счетчик цифр
                            break;
                        default:
                            count++;
                            break;
                    }
                }
                else
                {
                    notCount++;
                }
            }
            if (notCount > 0)
            {       
                return 0;
            }
            else
            {   
                return count;
            }
        }
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Здравствуйте, это программа подсчета цифр в цисле!");
            Console.Write("Введите число: ");
            number = Console.ReadLine();
            
            if(countDigits(number) == 0)
            {
                Console.WriteLine("Вы ввели не число");
            }
            else
            {
                Console.WriteLine($"Количество цифр в числе составляет: {countDigits(number)}");
            }
            
            Console.ReadKey();
        }
    }
}
