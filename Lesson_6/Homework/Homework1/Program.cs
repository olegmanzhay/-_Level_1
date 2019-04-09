/*Задача1.
 * Изменить программу вывода таблицы функциивывода таблицы функции так, 
 * чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 Манжай Олег
 */
using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x);
public delegate double Fun1(double b, double c);

class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static string Table(Fun F, double x, double b)
    {
        string result = string.Empty;
        result +="----- X ----- Y -----\n";
        while (x <= b)
        {
            result+=($"| {x,8:0.000} | {F(x),8:0.000} |\n");
            x += 1;
        }
        result+="---------------------";
        return result;
    }
    public static string Table(Fun1 F, double a, double x, double d)
    {
        string result = string.Empty;
        result += "----- X ----- Y -----\n";
        while (x <= d)
        {
            result +=($"| {x,8:0.000} | {F(a,x),8:0.000} |\n");
            x += 1;
        }
        result +="---------------------";
        return result;
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x)
    {
        return x*x*x;
    }
    public static double MyFunc1(double a, double x)
    {
        return a * x * x;
    }
    public static double MyFunc2(double a,double x)
    {
        return a*Math.Sin(x);
    }

    static void Main()
    {
        #region старая программа
        //// Создаем новый делегат и передаем ссылку на него в метод Table
        //Console.WriteLine("Таблица функции MyFunc:");
        //// Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        //Table(new Fun(MyFunc), -2, 2);
        //Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
        //// Упрощение(c C# 2.0).Делегат создается автоматически.            
        //Table(MyFunc, -2, 2);
        //Console.WriteLine("Таблица функции Sin:");
        //Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
        //Console.WriteLine("Таблица функции x^2:");
        //// Упрощение(с C# 2.0). Использование анонимного метода
        //Table(delegate (double x) { return x * x; }, 0, 3);
        #endregion

        double a;
        Console.WriteLine("Введите а: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Таблица функции MyFunc1:");
        Console.WriteLine(Table(MyFunc1, a, -2, 2)); 
        Console.WriteLine();
        Console.WriteLine("Таблица функции MyFunc2(Sin):");
        Console.WriteLine(Table(MyFunc2, a, -2, 2));
        Console.ReadKey();

    }
}

