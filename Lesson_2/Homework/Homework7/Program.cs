/*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        /// <summary>
        /// Рекурсивный метод возвращающий все числа из диапазона
        /// </summary>
        /// <param name="number1">начало диапазона</param>
        /// <param name="number2">конец диапазона</param>
        static void CountNumber(int number1, int number2)
        {

            int i = number1;
            if (i != number2)
            {

                Console.WriteLine($"Число = {i}");
                i++;
                CountNumber(i, number2);

            }
            else
            {
                Console.WriteLine($"Число = {i}");
            }

        }

        //Прошу разобрать как работает данный кусок кода, а именно почему после 2 returna идет продолжение рекурсии
        static int SummNumber(int number1, int number2, int summ)
        {
            int i = number1;
            //int summ = number1; //Есть ли какая-то возможность игнорировать код после на 2 и последующих итерациях?
            if (i != number2)
            {
                summ += i;
                i++;
                return SummNumber(i, number2, summ);

            }
            else
            {
                summ += number2;
            }
            return summ;
        }
        /*static int SummNumber2(int number1, int number2)
        {
            int i = number1;
            int summ = number1; //Есть ли какая-то возможность игнорировать код после 1 итерации?
            if (i != number2)
            {
                summ += i;
                i++;
                SummNumber(i, number2, summ);

            }
            else
            {
                summ += number2;
            }
            return summ;
        }*/
        static void Main(string[] args)
        {
            int a, b, result = 0;
            Console.Write("Введите начало диапазона: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            b = int.Parse(Console.ReadLine());
            CountNumber(a, b);
            Console.WriteLine($"Cумма всех чисел на промежутке равна: {SummNumber(a, b, result)}");
            //Console.WriteLine($"Cумма всех чисел на промежутке равна: {SummNumber2(a, b)}");
            Console.ReadKey();
        }
    }
}
