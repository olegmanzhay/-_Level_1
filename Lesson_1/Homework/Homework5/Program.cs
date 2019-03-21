using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static string Print(string str1, string str2, string str3, int x, int y)
        {
            string result = $"Ваше имя: {str1}, ваша фамилмя: {str2}, ваш город: {str3}";
            Console.SetCursorPosition(x, y);
            return result;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 11;
            string name, surname, city;
            Console.WriteLine("Напиши свое имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Напиши свою фамилию: ");
            surname = Console.ReadLine();
            Console.WriteLine("Напиши свой город: ");
            city = Console.ReadLine();

            Console.SetCursorPosition(10, 10);
            Console.WriteLine($"Ваше имя: {name}, ваша фамилмя: {surname}, ваш город: {city}");

            Console.WriteLine(Print(name, surname, city, x, y));

            Console.ReadKey();
        }
    }
}
