/*
 Задача 2.
    Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
    а)Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
    Использовать массив (или список) делегатов, в котором хранятся различные функции.
    б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
    Пусть она возвращает минимум через параметр (с использованием модификатора out).
Манжай Олег
 */
using System;
using System.IO;
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
            List<double> mass = new List<double>(); // значения функции
            double min;//минимальное значение функции
            List<MathFunction.function> Functions = new List<MathFunction.function>();// список функций через делегаты
            Functions.Add(MathFunction.F1);
            Functions.Add(MathFunction.F2);
            Functions.Add(MathFunction.F3);
            Functions.Add(MathFunction.F4);
            Functions.Add(MathFunction.F5);
            List<MathFunction.function1> Functions1 = new List<MathFunction.function1>();
            Functions1.Add(MathFunction.F6);
            Functions1.Add(MathFunction.F7);
            Console.WriteLine("1) y=x");
            Console.WriteLine("2) y=x^2 - 2x");
            Console.WriteLine("3) y=x^3-x^2-2x");
            Console.WriteLine("4) y=Sin(x)");
            Console.WriteLine("5) y=Cos(x)");
            Console.WriteLine("6) y=ax^+bx+c");
            Console.WriteLine("7) x^2/a^2 - c^2/b^2 - 1");
         

            Console.Write("Выбирите из представленного списка нужный Вам номер функции: ");
            int number =int.Parse(Console.ReadLine());
            if (number <= 5)
            {
                for (int i = 0; i < Functions.Count; i++)
                {
                    if (i == number - 1)
                    {
                        Console.Write("Введите начало диапазона: ");
                        double start = double.Parse(Console.ReadLine());
                        Console.Write("Введите конец диапазона: ");
                        double finish = double.Parse(Console.ReadLine());
                        Console.Write("Введите шаг: ");
                        double step = double.Parse(Console.ReadLine());
                        MathFunction.SaveFunc("data.bin", Functions[i], start, finish, step);
                        Console.WriteLine($"Минимальное значение составляет: {MathFunction.Load("data.bin")}");
                        mass = MathFunction.Load1("data.bin", out min);
                        Console.WriteLine("Все значения функции: ");
                        for (int j = 0; j < mass.Count; j++)
                        {
                            Console.Write($"{mass[j]} ");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Минимальное значение  = {min}");
                    }
                }
            }
            else if(number > 5 && number <= 7)
            {
                for (int i = 0; i < Functions1.Count; i++)
                {
                    if (i == number - 6)
                    {
                        Console.Write("Введите а: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите c: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.Write("Введите начало диапазона: ");
                        double start = double.Parse(Console.ReadLine());
                        Console.Write("Введите конец диапазона: ");
                        double finish = double.Parse(Console.ReadLine());
                        Console.Write("Введите шаг: ");
                        double step = double.Parse(Console.ReadLine());
                        MathFunction.SaveFunc("data.bin", Functions1[i], start, finish, step,a,b,c);
                        Console.WriteLine($"Минимальное значение составляет: {MathFunction.Load("data.bin")}");
                        mass = MathFunction.Load1("data.bin", out min);
                        Console.WriteLine("Все значения функции: ");
                        for (int j = 0; j < mass.Count; j++)
                        {
                            Console.Write($"{mass[j]} "); 
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Минимальное значение  = {min}");
                    }
                }
            }
            Console.ReadKey();
        }

    }
}