/*4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу:
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 Манжай Олег*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        /// <summary>
        /// Проверяет верность введеного логина и пароля
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>1 - успешно, 0 - неудача</returns>
        static bool test(string login, string password)
        {
            if(login == "root" && password == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string login, password;
            int iterator=0; // счетчик неудачных попыток
            bool result;    // результат проверки 

            Console.WriteLine("Регистрация!");
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ведите ваш логин: ");
                login = Console.ReadLine();
                Console.Write("Ведите ваш пароль: ");
                password = Console.ReadLine();
                result = test(login, password);
                if (result == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы успешно вошли в систему!");
                }
                else
                {
                    if (2 - iterator == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы исчерпали все попытки входа, перезагрузите программу!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Введите парол заново, у вас осталось {2 - iterator} попытки");
                        
                    }
                    iterator++;
                }
            } while (iterator != 3 && result ==false);
            Console.ReadKey();
        }
    }
}
