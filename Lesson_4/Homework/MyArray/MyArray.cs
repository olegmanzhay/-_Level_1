using System;

namespace MyArray
{
    public class MyArray
    {
        int[] a;

        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = el;
            }
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        // Чтобы констукторы отличались, передаю булевую переменную
        public MyArray(int n, int min, int step, bool flag)
        {
            double k = 0;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = min + (int)k;
                k += step;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }

        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int[] Inverse(MyArray b)
        {
            int[] newmass = new int[a.Length];
            newmass = a;
            for (int i = 0; i < newmass.Length; i++)
            {

                newmass[i] = (-1) * newmass[i];
            }
            return newmass;
        }
        public int[] Multi(MyArray b, int number)
        {

            for (int i = 0; i < a.Length; i++)
            {

                a[i] = number * a[i];
            }
            return a;
        }
        public int MaxCount(MyArray b)
        {
            int maxCount = 0;
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == max)
                {
                    maxCount++;
                }
            }
            return maxCount;
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
