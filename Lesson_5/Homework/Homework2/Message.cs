using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    static class Message
    {
        /// <summary>
        /// Возвращает строку, содержащую слова которые содержат не более n символов
        /// </summary>
        /// <param name="str">начальная строка</param>
        /// <param name="n">количество символов</param>
        /// <returns>тип string</returns>
        public static string func1(string str, int n)
        {
            string newstr = string.Empty;
            int k = 0; // начало диапазона
            for (int i = 0; i < str.Length; i++)
            {
                if (k == 0)
                {
                    if (str[i] == ' ')
                    {
                        if (str.Substring(k, i - k).Length <= n)
                        {
                            newstr += str.Substring(k, i - k) + ' ';
                            k = i;
                        }
                        else
                        {
                            k = i;
                        }
                    }
                }
                else
                {
                    if (str[i] == ' ')
                    {
                        if (str.Substring(k + 1, i - (k + 1)).Length <= n)
                        {

                            newstr += str.Substring(k + 1, i - (k + 1)) + ' ';
                            k = i;

                        }
                        else
                        {
                            k = i;
                        }
                    }
                    else if (i == (str.Length - 1))
                    {
                        if (str.Substring(k + 1, i - k).Length <= n)
                        {

                            newstr += str.Substring(k + 1, i - k);
                        }
                    }
                }
            }
            return newstr;
        }

        /// <summary>
        /// Возвращает строку с удаленными словами при наличии n-ого символа
        /// </summary>
        /// <param name="str">Начальная строка</param>
        /// <param name="n">Символ</param>
        /// <returns>Обновленная строка</returns>
        public static string func2(string str, char n)
        {
            string newstr = string.Empty; // строка для хранения новой строки
            int k = 0; // начало диапазона
            for (int i = 0; i < str.Length; i++)
            {
                if (k == 0)
                {
                    if (str[i] == ' ')
                    {
                        if (str.Substring(k, i - k)[i - 1 - k] != n)
                        {
                            newstr += str.Substring(k, i - k) + ' ';
                            k = i;
                        }
                        else
                        {
                            k = i;
                        }
                    }
                }
                else
                {
                    if (str[i] == ' ')
                    {
                        if (str.Substring(k + 1, i - (k + 1))[i - 1 - (k + 1)] != n)
                        {

                            newstr += str.Substring(k + 1, i - (k + 1)) + ' ';
                            k = i;

                        }
                        else
                        {
                            k = i;
                        }
                    }
                    else if (i == (str.Length - 1))
                    {
                        if (str.Substring(k + 1, i - k)[i - 1 - k] != n)
                        {

                            newstr += str.Substring(k + 1, i - k);
                        }
                    }
                }
            }
            return newstr;
        }

        /// <summary>
        /// самое длинное слово в сообщении
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string func3(string str)
        {
            int max = 0;// место для хранения максимального значения длинны слова
            string newstr = string.Empty; // строка для хранения новой строки
            int k = 0; // начало диапазона
            for (int i = 0; i < str.Length; i++)
            {
                if (k == 0)// символ начала строки
                {
                    if (str[i] == ' ') // дошли до конча слова
                    {
                        if (str.Substring(k, i - k).Length > max)
                        {
                            max = str.Substring(k, i - k).Length;
                            newstr = str.Substring(k, i - k);
                            k = i;
                        }
                        else
                        {
                            k = i;
                        }
                    }
                }
                else
                {
                    if (str[i] == ' ')
                    {
                        if (str.Substring(k + 1, i - (k + 1)).Length > max)
                        {
                            max = str.Substring(k + 1, i - (k + 1)).Length;
                            newstr = str.Substring(k + 1, i - (k + 1));
                            k = i;
                        }
                        else
                        {
                            k = i;
                        }
                    }
                    else if (i == (str.Length - 1))
                    {
                        if (str.Substring(k + 1, i - k).Length > max)
                        {
                            max = str.Substring(k + 1, i - k).Length;
                            newstr = str.Substring(k + 1, i - k);
                        }
                    }
                }
            }
            return newstr;
        }
    }
}
