using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    static class StaticClass
    {
        /// <summary>
        /// Возвращает количество пар в массиве
        /// </summary>
        /// <param name="a">массив чисел</param>
        /// <returns>кколичество пар</returns>
        public static int para(int[] a)
        {
            int iterator = 0; // количество пар 
            int k = 0; // номер пары 
            for (int i = 0; i < a.Length; i++)
            {
                if (i + 1 < a.Length)
                {
                    if ((((a[i] % 3 == 0 && a[i] != 0) || (a[i + 1] % 3 == 0 && a[i + 1] != 0))) && !((a[i] % 3 == 0 && a[i] != 0) && (a[i + 1] % 3 == 0 && a[i + 1] != 0)))
                    {
                        k++;
                        Console.WriteLine($"Пара {k} = {a[i]} {a[i + 1]} ");
                        iterator++;
                    }
                }
            }
            return iterator;
        }
        /// <summary>
        /// Возвращает массив чисел
        /// </summary>
        /// <returns>Массив чисел</returns>
        public static int[] Reader() 
        {
            int[] mass = new int[20];
            try
            {
                string s = File.ReadAllText("file1.txt");
                string[] a = s.Split(' ');

                for (int i = 0; i < a.Length; i++)
                {
                    mass[i] = int.Parse(a[i]);
                }
                return mass;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не открыт ваш массив не заполнен");
                return mass;
            }
        }
    }
}
