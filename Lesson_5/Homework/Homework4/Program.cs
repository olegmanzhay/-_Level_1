/*Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
каждая из следующих N строк имеет следующий формат:
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа выводит информацию о среднем балле студента, а также выводит 3 наихудщих средних балла!");
            Console.WriteLine("На текущий момент в каталоге находится файл \"INPUT.txt\", в нем находится список студентов и их количество");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сейчас у вас есть возможность править файл!");
            Console.ResetColor(); // вернем цвет консоли
            Console.WriteLine("Нажмите Enter для запуска программы");
            Console.ReadKey();
            Console.WriteLine();
            List<string> newString = new List<string>();// список для хранения Фамилии Имени среднего балла
            int N=0;//количество студентов
            Student b = new Student();
            newString = b.GetList(b,ref N);
            int k, j;
            double min = double.Parse(newString.Min());//минимальный средний балл
            Console.WriteLine($"Количество студентов: {N}");
            for (j = 2, k = 0; j < newString.Count; j += 3, k += 3) // бежим по циклу  и выводим средний балл студента
            {
                Console.WriteLine($"Средний балл {newString[k]} {newString[k + 1]} = {newString[j]} ");
            }
            Console.WriteLine();
            for (j = 2, k = 0; j < newString.Count; j += 3, k += 3)// бежим по циклу и выводим самый худший балл, после этого удаляем его из списка для нахождения других 
            {
                if (min == double.Parse(newString[j]))
                {
                    Console.WriteLine($"Худщий бал 1 {newString[k]} {newString[k + 1]} = {newString[j]} ");
                    newString.RemoveAt(j);//Удаляем Фамилию
                    newString.RemoveAt(j - 1);//удаляем Имя
                    newString.RemoveAt(j - 2);//удаляем балл
                    j -= 3; // возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                    k -= 3;// возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                }
            }
            min = double.Parse(newString.Min());
            for (j = 2, k = 0; j < newString.Count; j += 3, k += 3)
            {
                if (min == double.Parse(newString[j]))
                {
                    Console.WriteLine($"Худщий бал 2 {newString[k]} {newString[k + 1]} = {newString[j]} ");
                    newString.RemoveAt(j);//Удаляем Фамилию
                    newString.RemoveAt(j - 1);//удаляем Имя
                    newString.RemoveAt(j - 2);//удаляем балл
                    j -= 3;// возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                    k -= 3;// возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                }
            }
            min = double.Parse(newString.Min());
            for (j = 2, k = 0; j < newString.Count; j += 3, k += 3)
            {
                if (min == double.Parse(newString[j]))
                {
                    Console.WriteLine($"Худщий бал 3 {newString[k]} {newString[k + 1]} = {newString[j]} ");
                    newString.RemoveAt(j);//Удаляем Фамилию
                    newString.RemoveAt(j - 1);//удаляем Имя
                    newString.RemoveAt(j - 2);//удаляем балл
                    j -= 3;// возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                    k -= 3;// возвращаемся на предыдущую итерацию, чтобы не потерять последующие данные
                }
            }
            Console.ReadKey();
        }
    }
}



