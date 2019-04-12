using System.Collections.Generic;

namespace Game2
{
    public class Game
    {
        Stack<int> MyStack= new Stack<int>();
        /// <summary>
        /// Записывает в Stack значения
        /// </summary>
        /// <param name="MyStack">Хранит значения с каждым нажатием кнопки</param>
        /// <param name="lblNumber">Число</param>
        /// <param name="lblCountMyStack">Количество попыток</param>
        public static void writeStack(Stack<int> MyStack, string lblNumber, string lblCountMyStack)
        {
            MyStack.Push((int.Parse(lblNumber)));
            MyStack.Push((int.Parse(lblCountMyStack)));
        }
        /// <summary>
        /// Удаляет из Stack 2 элемента
        /// </summary>
        /// <param name="MyStack">Stack</param>
        public static void deleteElementStack(Stack<int> MyStack)
        {
            MyStack.Pop();
            MyStack.Pop();
        }
    }
}
