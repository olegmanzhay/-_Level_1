/*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr; // первоначальная строка
            int count; // количество символов 
            char symbol; // символ удаления
            Console.Write("Введите вашу строку: ");
            myStr = Console.ReadLine();
            Console.Write("Введите число: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("Введите символ удаления слова: ");
            symbol = (char)Console.Read();
            Console.WriteLine();
            Console.WriteLine($"Слова содержащие количество символов меньше или равно {count}: {Message.func1(myStr, count)}");
            Console.WriteLine($"Слова без символа на конце слова {symbol}: {Message.func2(myStr,symbol)}");
            Console.WriteLine($"Самое длинное слово: {Message.func3(myStr)} имеет {Message.func3(myStr).Length} символов");
            Console.ReadKey();

        }
    }
}
