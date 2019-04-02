using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray2
{
    public class MyArray2
    {
        int[,] a;
        public MyArray2(int n, int k)
        {
            a = new int[n, k];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] = r.Next(0, 10));
                }
                Console.WriteLine();
            }
        }
        public MyArray2(int n, int k, string input, string output)
        {
            a = new int[n, k];
            Random r = new Random();
            try
            {
                using (StreamWriter sw = new StreamWriter(input))
                {
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            a[i, j] = r.Next(0, 10);
                            sw.Write($"{a[i, j].ToString()} ");
                        }
                        sw.WriteLine();
                    }
                }
                using (StreamReader sr = new StreamReader(input))
                {
                    string buffer;
                    int[,] result = new int[n, k];
                    for (int i = 0; i < n; i++)
                    {
                        buffer = sr.ReadLine();
                        string[] a = buffer.Split(' ');
                        for (int j = 0; j < a.Length - 1; j++)
                        {
                            result[j, i] = int.Parse(a[j]);
                        }
                    }
                    Console.WriteLine("Массив считанный из файла");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            Console.Write(result[j, i]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Файл не найден");
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (max < a[i, j])
                        {
                            max = a[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Summ(MyArray2 b)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }
        public List<int> Element(MyArray2 b, ref List<int> index)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];

                    }
                }
            }
            int[] mass = new int[2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max == a[i, j])
                    {
                        mass[0] = i;
                        mass[1] = j;
                        index.Add(mass[0]);
                        index.Add(mass[1]);
                    }
                }
            }
            return index;
        }
        public void SWriter(MyArray2 b, string output, ref List<int> index)
        {
            int result1 = Summ(b);
            int result2 = b.Min;
            int result3 = b.Max;
            int d = 0;
            using (StreamWriter sw = new StreamWriter(output))
            {
                sw.WriteLine($"Cумма элементов массива: {result1.ToString()}");
                sw.WriteLine($"Минимальный элемент: {result2.ToString()}");
                sw.WriteLine($"Максимальный элемент:{result3.ToString()}");
                sw.Write($"Индекс максимальный элемент: ");
                foreach (int i in index)
                {
                    if (d % 2 == 0 && d != 0)
                    {
                        sw.Write(" ");
                        sw.Write(i + 1);
                    }
                    else
                    {
                        sw.Write(i + 1);
                    }
                    d++;
                }
            }
        }
    }
}
