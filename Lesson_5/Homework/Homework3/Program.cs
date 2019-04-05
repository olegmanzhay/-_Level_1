using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;
            string str2 = string.Empty;
            Console.WriteLine("Введите первую строку: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            str2 = Console.ReadLine();
            Console.WriteLine(str1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToUpper).OrderBy(x => x)));
            Console.ReadKey();
        }
    }
}
