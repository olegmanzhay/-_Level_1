using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        /// <summary>
        /// Изменяет первую букву на заглавную
        /// </summary>
        /// <param name="newname"></param>
        /// <param name="newsurname"></param>
        static void capitaLetter(ref string newname, ref string newsurname)
        {
            newname = newname.Substring(0, 1).ToUpper() + newname.Remove(0, 1);
            newsurname = newsurname.Substring(0, 1).ToUpper() + newsurname.Remove(0, 1);
        }
        static void Main(string[] args)
        {

            string name, surname;
            double weight, height;
            int age;

            Console.WriteLine("Добрый день! Заполните пожалуйста анкету");
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашe фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите ваш рост в сантиметрах: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес в килограммах: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());

            capitaLetter(ref name, ref surname); // Имя и фамилия с большой буквы

            Console.WriteLine("Ваше имя: " + name + ". Ваша фамилия: " + surname + ". Ваш возраст: " + age + ". Ваш вес: " + weight + " кг" + ". Ваш рост: " + height + " см");
            Console.WriteLine("Ваше имя: {0}. Ваша фамилия: {1}. Ваш возраст: {2}. Ваш вес: {3} кг. Ваш рост: {4} см", name, surname, age, weight, height);
            Console.WriteLine($"Ваше имя: {name}. Ваша фамилия: {surname}. Ваш возраст: {age}. Ваш вес: {weight} кг. Ваш рост: {height} см");

            Console.ReadKey();
        }
    }
}

