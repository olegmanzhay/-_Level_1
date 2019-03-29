using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RationalNumbers
{
    public class Rational
    {
        //Числитель и знаменатель
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        #region private_methods

        //Сокращаем дробь
        private void Reduce1()
        {
            this.Numerator = this.Numerator > 0 ? this.Numerator : -this.Numerator;
            this.Denominator = this.Denominator > 0 ? this.Denominator : -this.Denominator;

            int maxval = Numerator > Denominator ? Numerator : Denominator;
            for (int i = maxval; i >= 2; maxval--)
            {
                if (Numerator % maxval == 0 && Denominator % maxval == 0)
                {
                    this.Numerator /= maxval;
                    this.Denominator /= maxval;
                    break;
                }
            }
        }

        //НОЗ - наименьший общий знаменатель
        private static int NOZ(int[] maxmin)
        {
            Array.Sort(maxmin);
            if (maxmin[1] % maxmin[0] == 0)
                return maxmin[1];

            int temp = 0;
            for (int i = 2; ; i++)
            {
                temp = maxmin[1] * i;
                if (temp % maxmin[0] == 0)
                {
                    break;
                }
            }
            return temp;
        }

        #endregion

        //Если в знаменателе 0
        public bool IsNan
        {
            get { return this.Denominator != 0 ? false : true; }
        }

        //В конструкторе сразу сокращаем дробь, если это возможно
        public Rational(int numerator, int denominator = 1)
        {
            if (numerator == 0)
            {
                this.Numerator = 0;
                this.Denominator = 1;
            }
            else if (numerator == denominator)
            {
                this.Numerator = 1;
                this.Denominator = 1;
            }
            else if (numerator > 0 && denominator > 0 || numerator < 0 && denominator < 0)
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
                Reduce1();

            }
            else if (numerator < 0 || denominator < 0)
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
                Reduce1();
                this.Numerator *= -1;
            }
        }

        //Умножаем рациональную дробь на число
        public static Rational operator *(Rational a, int b)
        {
            return new Rational(a.Numerator * b, a.Denominator);
        }

        //Складываем рациональную дробь с рациональной дробью
        public static Rational operator +(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            Rational result1 = new Rational(1), result2 = new Rational(1);
            int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
            result1.Numerator = noz / a.Denominator * a.Numerator;
            result2.Numerator = noz / b.Denominator * b.Numerator;
            return new Rational(result1.Numerator + result2.Numerator, noz);
        }

        //Вычитаем рациональную дробь на рациональную дробь
        public static Rational operator -(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            Rational result1 = new Rational(1), result2 = new Rational(1);
            int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
            result1.Numerator = noz / a.Denominator * a.Numerator;
            result2.Numerator = noz / b.Denominator * b.Numerator;
            return new Rational(result1.Numerator - result2.Numerator, noz);
        }

        //Умножаем рациональную дробь на рациональную дробь
        public static Rational operator *(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        //Делим рациональную дробь на рациональную дробь
        public static Rational operator /(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Numerator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            return new Rational(a.Numerator / b.Numerator, a.Denominator / b.Denominator);
        }

        //Переопределяем метод ToString() для удобства вывода на экран
        public override string ToString()
        {
            return String.Format("[Rational: {0}/{1}]", this.Numerator, this.Denominator);
        }

        //Инструкция по явному преобразованию Rational в int
        public static explicit operator int(Rational a)
        {
            if (a.Numerator < a.Denominator || a.Denominator == 0)
                throw new ArgumentException();

            return (int)(a.Numerator / a.Denominator);
        }

        //Инструкция по неявному преобразованию Rational в double
        public static implicit operator double(Rational a)
        {
            return (double)a.Numerator / (double)a.Denominator;
        }

        //Инструкция по неявному преобразованию int в Rational
        public static implicit operator Rational(int a)
        {
            return new Rational(a, 1);
        }
    }

    class Program
    {
        private static void print(object outtext)
        {
            Console.WriteLine("_______\nЗадача: " + outtext);
        }

        public static void Main()
        {
            print("IsNan 2/0 ? " + new Rational(2, 0).IsNan);
            Rational r35 = new Rational(1, 4);
            Rational r36 = new Rational(-2, 4);
            //Умножаем рациональную дробь на число
            print("Умножаем рациональную дробь " + r35 + " на число 4\n" + r35 * 4);

            //Складываем рациональные дроби
            Rational sumdr = r35 + r36;
            print("Складываем рациональные дроби " + r35 + " и " + r36 + " \n" + sumdr);

            //Вычитаем рациональные дроби
            Rational razn = new Rational(1, 2) - new Rational(1, 4);
            print("---Вычитаем рациональные дроби: " + razn);

            //Складываем рациональные дроби NaN
            print("Складываем рациональные дроби NaN: " + (new Rational(1, 2) + new Rational(1, 0)).IsNan);

            //Вычитаем рациональные дроби NaN
            print("Вычитаем рациональные дроби NaN: " + (new Rational(1, 2) - new Rational(1, 0)).IsNan);

            //Умножаем рациональные дроби NaN
            print("Умножаем рациональные дроби NaN: " + (new Rational(1, 2) * new Rational(1, 0)).IsNan);

            //Делим рациональные дроби NaN
            print("Делим рациональные дроби NaN: " + (new Rational(1, 2) / new Rational(1, 0)).IsNan);

            //Умножаем рациональные дроби
            print("Умножаем рациональные дроби: " + (new Rational(-1, 2) * new Rational(1, 2)));

            //Делим рациональные дроби
            print("Делим рациональные дроби: " + (new Rational(1, 4) / new Rational(-1, 2)));

            //Делим рациональные дроби на 0
            print("Делим рациональные дроби на 0: " + (new Rational(1, 2) / new Rational(0, 5)).IsNan);

            int aa = (int)new Rational(2, 1);
            print("Преобразуем в int: " + aa);

            double v = new Rational(1, 2);
            print("Преобразуем в double: " + v);

            Rational rr = 5;
            print("Число " + rr.Numerator + " в рациональную дробь: " + rr);
        }
    }
}