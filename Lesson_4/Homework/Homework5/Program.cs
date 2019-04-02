using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k; // размерность массива
            Console.Write("Введите количество строк в массиве: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            k = int.Parse(Console.ReadLine());
            MyArray2.MyArray2 a = new MyArray2.MyArray2(n, k);

            Console.WriteLine($"Сумма всехэлементов массива: {a.Summ(a).ToString()}");
            Console.WriteLine($"Максимальный элемент массива: {a.Max.ToString()}");
            Console.WriteLine($"Минимальный элемент массива: {a.Min.ToString()}");
            
            List<int> maxElement = new List<int>(); // Список для индексов максимальных элементов
            a.Element(a, ref maxElement); // метод нахождения индекса максимального элемента массива 
            int d = 0;// счетчик для перевода строки, как только выводится 2 координаты индекса
            Console.Write("Индекс максимального элемента сотавялет: ");
            foreach (int i in maxElement)
            {
                if (d % 2 == 0 && d != 0)
                {
                    Console.Write(" ");
                    Console.Write(i + 1);
                }
                else
                {
                    Console.Write(i + 1);
                }
                d++;
            }
            Console.WriteLine();
            Console.WriteLine();

            string inputFile = "INPUT.TXT"; // файл для записи
            string outputFile = "OUTPUT.TXT"; // файл для чтения 
            MyArray2.MyArray2 b = new MyArray2.MyArray2(n, k, inputFile, outputFile);
            b.SWriter(b, outputFile, ref maxElement); // метод записи в файл 
            Console.ReadKey();
        }
    }
}
