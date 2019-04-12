using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    static class Sum
    {
        /// <summary>
        /// Возвращает сумму
        /// </summary>
        /// <param name="numbers">Список чисел для сложения</param>
        /// <param name="a">число</param>
        /// <param name="str">Выражение</param>
        /// <returns></returns>
        public static List<int> SumNumbers(List<int> numbers, string a, string str)
        {
            int result = 0;
            for (int i = 0, j = 0; i < str.Length; i++)
            {
                if (str[i] != '+')
                {
                    a += str[i];
                }
                if (str[i] == '+' || i == str.Length - 1)
                {
                    result = int.Parse(a);
                    numbers.Add(result);
                    a = string.Empty;
                }
            }
            return numbers;
        }
    }
}
