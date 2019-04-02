using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    struct Access
    {
        string login;
        string password;

        public bool Form(Access x)
        {
            string[] loginPasword = File.ReadAllLines("Login.txt"); // запись в массив логина и пароля
            int iterator = 0; // доступ в систему
            int i;
            int k = 0; // количество попыток

            for (i = 0; i < loginPasword.Length; i += 2)
            {
                x.login = loginPasword[i];
                x.password = loginPasword[i + 1];
                if (x.login == "root" && x.password == "GeekBrains")
                {
                    iterator++;
                    k++;
                    break;
                }
                else
                {
                    k++;
                }
            }
            if(i-2< 3)
            {
                if (iterator == 1)
                {
                    Console.WriteLine($"Вы вошли в систему с  {k} раза");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Ваши попытки закончились!");
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Добрый день! Это программа входа в систему! \nУ вас Есть 3 попытки, чтобы в нее войти! Занесите праильный вариант логина и пароля в файл");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Чтобы узнать, вошли вы в систему или нет - нажмите Enter");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Access muStruct = new Access();
            if(muStruct.Form(muStruct) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы успешно вошли в систему");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите корректный логин и пароль");
            }
            
            Console.Read();

        }
    }
}
