using System;

namespace Homework
{
    public class SubtractionFraction
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
                    if(number2 != 0)
                        number1 = number1 - number2;
                    else
                    {
                        number2+=2;
                        number1 = number1 - number2;
                    }
                }
                else
                {
                    if(number1>0)
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
        /// Выводит на экран результат вычитания дробей
        /// </summary>
        /// <param name="a1">Числитель первой дроби</param>
        /// <param name="b1">Знаменатель первой дроби</param>
        /// <param name="c1">Целая часть  первой дроби</param>
        /// <param name="a2">Числитель второй дроби</param>
        /// <param name="b2">Знаменатель второй дроби</param>
        /// <param name="c2">Целая часть  второй дроби</param>///
        static public void subtracting(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            
            if (c1 > 0 || c1<0)// Перевод в неправильную дробь  1 дроби 
            {
                a1 = c1 * b1 + a1;
            }
            if (c2 > 0 || c1 < 0) // Перевод в неправильную дробь 2 дроби 
            {
                a2 = c2 * b2 + a2;
            }
            int commonDenominator; // НОД
            int integer; // целая часть
            int k1, k2; // коэфициенты умножения
            if (b1 == b2)
            {
                commonDenominator = b1;
                int nod = gcd(a1 - a2, commonDenominator);//Поиск НОД
                if ((a1 - a2) / nod < commonDenominator / nod) // Если целая часть новой дроби меньше знаменателя
                {
                    integer = (a1 - a2) / commonDenominator;
                    if ((a1 - a2) / nod != 0) // Если дробь!= 0
                    { 
                        if (integer == 0)
                        {
                            Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {(a1 - a2) / nod}/{commonDenominator / nod}");
                        }
                        else
                        {
                            if (((a1 - a2) - integer * b1) / nod != 0)
                                Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer} | {((a1 - a2) - integer * b1) / nod}/{commonDenominator / nod}");
                            else
                                Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}");
                        }
                    }
                    else
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {(a1 - a2) / nod}");
                }
                else
                {
                    integer = (int)(((a1) - (a2)) / commonDenominator);
                    if((a1) - (a2) != commonDenominator && (a1-a2)!=0)//Если числитель != знаменателю и числитель != 0 
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {integer}|{((a1 - a2) - integer * commonDenominator) / nod} / {commonDenominator / nod}");
                    else
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {integer}");
                }
            }
            else if (b1 % b2 == 0) // Если остаток от деления 1 знаменателя от второго == 0
            {
                
                k1 = b1 / b2; // Коэфициент  = знаменатель 1/знаменатель 2
                int a = (a1 - a2 * k1); // числитель новой дроби
                integer = (int)((a) / b1); // целая часть новой дроби

                int b = b1;
                if (a == 0)
                {
                    Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}");

                }
                int nod = gcd(a, b);//Поиск НОД
                if (nod > 1)
                {

                    Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}| {(a-b1) / nod}/{b1 / nod}");

                }
                else
                {
                    if (integer == 0)//Если целая часть == 0
                    {
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {a / nod}/{b1 / nod}");
                    }
                    else
                    {
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}|{(a-b*integer)/ nod}/{b1 / nod}");
                    }

                }
            }
            else if (b1 % b2 > 0) // Если остаток от деления 1 знаменателя от второго >0 (всегда больше, если знаменатели не кратны)
            {
                commonDenominator = b2 * b1; // общий делитель 
                k1 = commonDenominator / b2; // коэфициент умножения 1 
                k2 = commonDenominator / b1; // коэфициент умножения 2 
                if (((a1 * k2) - (a2 * k1)) > commonDenominator) // Если числитель новой дроби > знаменателя
                {
                    integer = (int)(((a1 * k2) - (a2 * k1)) / commonDenominator); // целая часть новой дроби
                    int a = (a1 * k2) - (a2 * k1) - (integer * commonDenominator);//числитель новой дроби 
                    int b = commonDenominator; // ОД
                    if (a == 0)
                    {
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}");
                    }
                    int nod = gcd(a, b); // поиск НОД
                    if (nod >= 1&& a!=0)
                    {
                        Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}| {a / nod}/{b / nod}");
                    }
                }
                else
                {
                    
                    int a = (a1 * k2) - (a2 * k1);//числитель новой дроби 
                    int b = commonDenominator;// ОД
                    int nod = gcd(a, b);//Поиск НОД
                    integer = (int)(((a1 * k2) - (a2 * k1)) / commonDenominator); // цела часть новой дроби 
                    if (integer == 0) {
                        if (a / nod != 0)
                            Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {a / nod}/{b / nod}");
                        else
                            Console.WriteLine($"{a1}/{b1} - {a2}/{b2} =  {integer}");
                    }
                    else
                    {
                        if (integer < 0)//Если целая часть ментше 0, умножаем числитель на -1, чтобы не выводилось 2 минуса 
                        {
                            if((((-1) * (a - integer * b)) / nod)!=0)
                                Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}| {(((-1) * (a - integer * b)) / nod)}/{b / nod}");
                            else
                                Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}");
                        }
                        else
                            Console.WriteLine($"{a1}/{b1} - {a2}/{b2} = {integer}| {((a - integer * b) / nod)}/{b / nod}");
                    }
                }
            }
        }
    }
}
