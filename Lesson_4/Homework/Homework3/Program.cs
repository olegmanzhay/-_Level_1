
using System;
namespace Homework3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minValue;
            int stepValue;
            int coutElements;
            bool flag = true;
           
            Console.Write("Введите начало диапазона: ");
            minValue = int.Parse(Console.ReadLine());
            Console.Write("Введите шаг: ");
            stepValue = int.Parse(Console.ReadLine());
            Console.Write("Введите количество элементов массива: ");
            coutElements= int.Parse(Console.ReadLine());

            MyArray.MyArray b = new MyArray.MyArray(coutElements, minValue, stepValue, flag);
            Console.WriteLine($"Первоначальный массив {b.ToString()} ");

            MyArray.MyArray resultInverse = new MyArray.MyArray(coutElements, minValue, stepValue, flag);
            Console.WriteLine($"Сумма всех элементов массива составляет: {b.Sum}");
            int[] resultinverse = new int[coutElements];
            resultinverse = resultInverse.Inverse(b);
            Console.Write($"Массив после инверсии: ");
            for (int i = 0; i < coutElements; i++)
            {
                Console.Write($"{resultinverse[i].ToString()} ");
            }
            Console.WriteLine();
            Console.Write("Введите множитель: ");
            number = int.Parse(Console.ReadLine());
            MyArray.MyArray resultMulti = new MyArray.MyArray(coutElements, minValue, stepValue, flag);
            int[] resultmulti = new int[coutElements];
            resultmulti = resultMulti.Multi(b,number);
            Console.Write($"Массив после умножения на {number}: ");
            for (int i = 0; i < coutElements; i++)
            {
                Console.Write($"{resultmulti[i].ToString()} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Массив остался без изменений: {b.ToString()}");
            Console.WriteLine();
            Console.WriteLine("Выполнение программы из методички");
            //Предыдущий код
            MyArray.MyArray a = new MyArray.MyArray(10, 0, 100);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.CountPositive);
            Console.WriteLine($"Количество максимальных элементов в массиве: {a.MaxCount(a)}");
            Console.ReadKey();
        }
    }
}
