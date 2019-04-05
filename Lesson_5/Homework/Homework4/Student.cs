using System.Collections.Generic;
using System.IO;

namespace Homework4
{
    class Student
    {
        public string name;
        public string surname;
        public List<string> GetList(Student a, ref int strN)
        {
            double score = 0;//место для хранинея суммы оценок
            string path = "MyFile.txt";
            List<string> myList = new List<string>();//список для хранения Фамилии Имени и среднего балла студента
            using (StreamReader sr = new StreamReader(path))
            {
                string newstr = string.Empty;// элемент строки файла(Фамилия, Имя, оценка1, оценка2, оценка3)
                string str = string.Empty;// хранение 
                int k = 0; // начало диапазона строки
                int iterator;
                strN = int.Parse(sr.ReadLine());//количество студентов
                int l = 0; //счетчики прохождения строки
                int z = 0; //счетчик добавления в список
                int d = 0; //счетчик одобрения того, что строка соответствует требованиям

                while (d != strN)//пока не будет достигнуто заданное количество студентов 
                {
                    str = sr.ReadLine();
                    iterator = 0;
                    k = 0;
                    for (int i = 0; i < str.Length; i++)// идем по всему файлу
                    {
                        if (k == 0)//начинаем с начала строки
                        {
                            if (str[i] == ' ') // дошло до конца слова
                            {
                                newstr = str.Substring(k, i - k); // Фамилия
                                if (newstr.Length >= 0 && newstr.Length <= 20) // условие из ДЗ, что  Фамилия не может превыщать 20 символов
                                {
                                    a.surname = newstr;
                                    myList.Add(a.surname);
                                    k = i;
                                    z++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (str[i] == ' ')// дошло до конца слова
                            {
                                if (iterator == 0) // Имя
                                {
                                    newstr = str.Substring(k + 1, i - (k + 1));
                                    if (newstr.Length >= 0 && newstr.Length <= 15)
                                    {
                                        a.name = newstr;
                                        myList.Add(a.name);
                                        k = i;
                                        iterator++;
                                        z++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else if (iterator == 1) // оценка1
                                {
                                    newstr = str.Substring(k + 1, i - (k + 1));
                                    score = double.Parse(newstr);
                                    k = i;
                                    iterator++;
                                }
                                else if (iterator == 2) // оценка2
                                {
                                    newstr = str.Substring(k + 1, i - (k + 1));
                                    score += double.Parse(newstr);
                                    k = i;
                                    iterator++;
                                }
                            }
                            else if (i == (str.Length - 1)) // оценка3
                            {
                                newstr = str.Substring(k + 1, i - k);
                                score += (double.Parse(newstr));
                                double averageScore = score / 3; // средний балл
                                myList.Add(averageScore.ToString());
                                z++;
                            }
                        }
                    }
                    l++;
                    if (l == (int)z / 3) // если в цикле строка соответствет 
                    {
                        d = (int)z / 3;
                    }
                    else
                    {
                        l--; // не засчитываем эту итерацию 
                    }
                }
            }
            return myList;
        }
    }
}
