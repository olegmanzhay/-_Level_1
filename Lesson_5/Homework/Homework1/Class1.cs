using System.Text.RegularExpressions;

namespace Homework1
{
    class Class1
    {
        public bool Account(string login, ref string comment)
        {
            bool flag;//флаг подтверждение или неподтверждения логина
            int iterator = 0;//количество успешных совпадений
            if (login.Length >= 2 && login.Length <= 10)
            {
                if (login[0] >= '0' && login[0] <= '9')
                {
                    comment = "Ваш логин не может начинаться с цифры ";
                    return false;
                }
                else
                {
                    comment = "Ваш логин  должен состоять из 2 до 10 символов";
                    for (int i = 0; i < login.Length; i++)
                    {

                        if (login[i] >= 'A' && login[i] <= 'Z' || login[i] >= 'a' && login[i] <= 'z' || login[i] >= '0' && login[i] <= '9')
                        {
                            iterator++;
                        }
                    }
                    if (iterator == login.Length)
                    {
                        flag = true;
                    }
                    else
                    {
                        comment = "Ваш Логин не соответствует требованиям задания";
                        flag = false;
                    }
                }
            }
            else
            {
                comment = $"Длина логина должна быть (больше 2 и меньше 10) включительно, а ваш логин состоит из {login.Length} символов";
                flag = false;
            }
            return flag;
        }
        public bool Account(string login)
        {
            string pat = @"\b[a-zA-Z]{1,1}[a-zA-Z0-9]{2,10}\b";
            Regex regex = new Regex(pat);
            if (regex.Match(login).Success)
            {
                return true;
            }
            else
                return false;
        }
    }
}
