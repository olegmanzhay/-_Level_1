using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework2
{
    class MathFunction
    {
        public delegate double function(double x);
        public delegate double function1(double x, double a, double b, double c);
        public static double F1(double x)
        {
            return x;
        }
        public static double F2(double x)
        {
            return Math.Pow(x, 2) - 2 * x;
        }
        public static double F3(double x)
        {
            return Math.Pow(x, 3) - Math.Pow(x, 2) - 2 * x;
        }
        public static double F4(double x)
        {
            return Math.Sin(x);
        }
        public static double F5(double x)
        {
            return Math.Cos(x);
        }
        public static double F6(double x, double a, double b, double c)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }
        public static double F7(double x, double a, double b, double c)
        {
            return (Math.Pow(x, 2) / Math.Pow(a, 2)) - (Math.Pow(c, 2) / Math.Pow(b, 2)) - 1;
        }

        public static void SaveFunc(string fileName, function Z, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Z(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFunc(string fileName, function1 Z, double a, double b, double h, double q, double w, double e)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Z(x, q, w, e));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static List<double> Load1(string fileName, out double min)
        {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> mass = new List<double>();
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                // заполняем список значениями функции
                mass.Add(bw.ReadDouble());
            }
            for (int i = 0; i < mass.Count; i++)
            {
                // Считываем значение и переходим к следующему
                if (mass[i] < min) min = mass[i];
            }
            bw.Close();
            fs.Close();
            return mass;

        }
    }
}
