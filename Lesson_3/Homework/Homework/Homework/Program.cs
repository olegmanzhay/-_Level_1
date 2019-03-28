using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Fraction
    {
        private int numerator; // числитель
        private int denominator; // знаменатель 
        private int integerPart; // целая часть

        public int Numerator // Инкапсуляция, свойство для доступа к числителю
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }  
        public int Denominator // Инкапсуляция, свойство для доступа к знаменателю
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }
        public int IntegerPart // Инкапсуляция, свойство для доступа к целой части
        {
            get
            {
                return integerPart;
            }
            set
            {
                integerPart = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
        
            Console.Write("Введите целую часть первой дроби: ");
            f1.IntegerPart = int.Parse(Console.ReadLine());
            Console.Write("Введите числитель первой дроби: ");
            f1.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель первой дроби: ");
            f1.Denominator = int.Parse(Console.ReadLine());

            Console.Write("Введите целую часть второй дроби: ");
            f2.IntegerPart = int.Parse(Console.ReadLine());
            Console.Write("Введите числитель второй дроби: ");
            f2.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель второй дроби: ");
            f2.Denominator = int.Parse(Console.ReadLine());

            SummFraction.summ(f1.Numerator, f1.Denominator, f1.IntegerPart, f2.Numerator, f2.Denominator, f2.IntegerPart);
            SubtractionFraction.subtracting(f1.Numerator, f1.Denominator, f1.IntegerPart, f2.Numerator, f2.Denominator, f2.IntegerPart);
            MultiplicationFraction.Multiplication(f1.Numerator, f1.Denominator, f1.IntegerPart, f2.Numerator, f2.Denominator, f2.IntegerPart);
            DivisionFraction.Division(f1.Numerator, f1.Denominator, f1.IntegerPart, f2.Numerator, f2.Denominator, f2.IntegerPart);

            Console.ReadKey();


        }
    }
}
