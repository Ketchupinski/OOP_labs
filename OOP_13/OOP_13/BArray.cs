/*
 * Створити абстрактний базовий клас Array з віртуальними методами додавання і
поелементної обробки масиву foreach( ). Розробити похідні класи AndArray і OrArray.
У першому класі операція додавання реалізується як перетин множин, а по-елементна
обробка представляє собою обчислення квадратного кореня. У другому класі
операція додавання реалізується як об’єднання, а по-елементна обробка – обчислення
логарифма.
*/

using System;

namespace OOP_13
{
    public abstract class BArray
    {
        public int[] Array { get; private set; }

        public BArray(int[] a)
        {
            Array = a;
        }

        public abstract int[] Add(BArray a);

        public abstract void ForEach();

        protected bool CheckSet(int[] set)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int check = set[i];
                for (int j = i + 1; j < set.Length; j++)
                {
                    if (check == set[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void ShowType()
        {
            Console.WriteLine("Object type: " + GetType().Name);
        }
    }

    
}