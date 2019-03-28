using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class SummFraction
    {
        /// <summary>
        /// Возвращает наибольший общий делитель двух чисел 
        /// </summary>
        /// <param name="number1">Числитель</param>
        /// <param name="number2">Знаменатель</param>
        /// <returns>НОД</returns>
        static private int gcd(int number1, int number2)
        {
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    if(number2!=0)
                        number1 = number1 - number2;
                    else
                    {
                        number2 += 2;
                        number1 = number1 - number2;
                    }
                }
                else
                {
                    if (number1!=0)
                        number2 = number2 - number1;
                    else
                    {
                        number1++;
                        number2 = number2 - number1;
                    }
                }
            }
            return number1;
        }
        /// <summary>
        /// Выводит на экран результат сложения дробей
        /// </summary>
        /// <param name="a1">Числитель первой дроби</param>
        /// <param name="b1">Знаменатель первой дроби</param>
        /// <param name="c1">Целая часть  первой дроби</param>
        /// <param name="a2">Числитель второй дроби</param>
        /// <param name="b2">Знаменатель второй дроби</param>
        /// <param name="c2">Целая часть  второй дроби</param>///
        static public void summ(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            if (c1 > 0 || c1< 0)
            {
                a1 = c1 * b1 + a1;
            }
            if (c2 > 0 || c2 < 0)
            {
                a2 = c2 * b2 + a2;
            }
            int commonDenominator;
            int integer;
            int k1, k2;
            if (b1 == b2)
            {
                commonDenominator = b1;
                int nod = gcd(a1 + a2, commonDenominator);
                if ((a1 + a2) / nod < commonDenominator / nod)
                {
                    Console.WriteLine($"{a1}/{b1} + {a2}/{b2} =  {(a1 + a2) / nod}/{commonDenominator / nod}");
                }
                else
                {
                    integer = (int)(((a1) + (a2)) / commonDenominator);
                    if (((a1 + a2) - integer * commonDenominator) / nod != 0 )
                    {
                        if (((a1 + a2) - integer * commonDenominator) != 0)
                            Console.WriteLine($"{a1}/{b1} + {a2}/{b2} =  {integer}|{((a1 + a2) - integer * commonDenominator) / nod} / {commonDenominator / nod}");
                        else
                            Console.WriteLine($"{a1}/{b1} + {a2}/{b2} =  {integer}");
                    }
                    else
                    {
                        Console.WriteLine($"{a1}/{b1} + {a2}/{b2} =  {integer}");
                    }
                }
            }
            else if (b1 % b2 == 0)
            {
                k1 = b1 / b2;
                integer = (int)(((a2 * k1) + a1) / b1);
                int a = ((a2 * k1) + a1) - (integer * b1);
                int b = b1;
                if (a == 0)
                {
                    Console.WriteLine($"{a1}/{b1} + {a2}/{b2} ={integer}");

                }
                int nod = gcd(a, b);
                if (nod >= 1)
                {

                    Console.WriteLine($"{a1}/{b1} + {a2}/{b2} ={integer}| {a / nod}/{b1 / nod}");

                }
                else
                {
                    Console.WriteLine($"{a1}/{b1} + {a2}/{b2} ={a / nod}/{b1 / nod}");

                }
            }
            else if (b1 % b2 > 0)
            {
                commonDenominator = b2 * b1;
                k1 = commonDenominator / b2;
                k2 = commonDenominator / b1;
                if (((a1 * k2) + (a2 * k1)) > commonDenominator)
                {
                    integer = (int)(((a1 * k2) + (a2 * k1)) / commonDenominator);
                    int a = (a1 * k2) + (a2 * k1) - (integer * commonDenominator);
                    int b = commonDenominator;
                    if (a == 0)
                    {
                        Console.WriteLine($"{a1}/{b1} + {a2}/{b2} ={integer}");
                    }
                    else
                    {
                        int nod = gcd(a, b);
                        if (nod >= 1)
                        {
                            Console.WriteLine($"{a1}/{b1} + {a2}/{b2} ={integer}| {a / nod}/{b / nod}");
                        }
                    }
                }
                else
                {
                    int a = (a1 * k2) + (a2 * k1);
                    int b = commonDenominator;
                    int nod = gcd(a, b);
                    Console.WriteLine($"{a1}/{b1} + {a2}/{b2} =  {a / nod}/{b / nod}");
                }
            }
        }
    }
}
