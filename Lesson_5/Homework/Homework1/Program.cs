/*Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
 * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Homework1
{
    class Program
    {
        /// <summary>
        /// Метод подтверждения правильности логина
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="comment">Причина неудачного ввода</param>
        /// <returns>bool</returns>
       

        /// <summary>
        /// Метод подтверждения правильности логина
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>bool</returns>
        
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            string login; //логин
            string comment = string.Empty; // причина неподтверждения пароля
            Console.Write("Введите Ваш логин: ");
            login = Console.ReadLine();

            if (a.Account(login, ref comment) == true)
                Console.WriteLine("Логин подтвержден");
            else
            {
                Console.WriteLine("Логин не был подтвержден");
                Console.WriteLine(comment);
            }
            Console.WriteLine();

            if (a.Account(login) == true)
                Console.WriteLine("Логин подтвержден");
            else
            {
                Console.WriteLine("Логин не был подтвержден");
            }

            Console.ReadKey();
        }

    }
}
