﻿using System;

namespace Homework
{
    public class DivisionFraction
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
                    if (number2 != 0)
                        number1 = number1 - number2;
                    else
                    {
                        number2 += 2;
                        number1 = number1 - number2;
                    }
                }
                else
                {
                    if (number1 != 0)
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
        /// Возвращает частное двух дробей
        /// </summary>
        /// <param name="a1">Числитель 1 дроби</param>
        /// <param name="b1">Знаменатель 1 дроби</param>
        /// <param name="c1">Целая часть 1 дроби</param>
        /// <param name="a2">Числитель 2 дроби</param>
        /// <param name="b2">Знаменатель 2 дроби</param>
        /// <param name="c2">Целая часть 1 дроби</param>
        static public void Division(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            if (c1 > 0 || c1 < 0)// Перевод в неправильную дробь  1 дроби 
            {
                a1 = c1 * b1 + a1;
            }
            if (c2 > 0 || c1 < 0) // Перевод в неправильную дробь 2 дроби 
            {
                a2 = c2 * b2 + a2;
            }
            int integer = (int)((a1 * b2) / (b1 * a2));
            int nod = 0;
            if (a1 * b2 > 0 && b1 * a2 > 0)
                nod = gcd((a1 * a2), b1 * b2);
            else if (a1 * b2 < 0 && b1 * a2 < 0)
                nod = gcd(Math.Abs((a1 * a2)), Math.Abs((b1 * b2)));
            else if (a1 * b2 < 0)
                nod = gcd(Math.Abs(a1 * b2), b1 * a2);
            else if (b1 * a2 < 0)
                nod = gcd(a1 * b2, Math.Abs(b1 * a2));

            if (integer == 0)
                Console.WriteLine($"{a1}/{b1} / {a2}/{b2} = {a1 * b2 / nod}/{b1 * a2 / nod}");
            else
            {
                if ((double)(((a1 * b2) - integer * (b1 * a2))) / nod != 0  || (double)((((a1 * b2) - integer * (b1 * a2))) / nod)<0)
                    Console.WriteLine($"{a1}/{b1} / {a2}/{b2} = {integer}| {(((a1 * b2) - integer * (b1 * a2))) / nod}/{(b1 * a2) / nod}");
                else
                    Console.WriteLine($"{a1}/{b1} / {a2}/{b2} = {integer}");
            }
        }
    }
}
