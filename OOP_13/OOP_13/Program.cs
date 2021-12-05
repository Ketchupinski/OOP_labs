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
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] x = new[] {1, 2, 5, 10, 20};
            int[] y = new[] {5, 25, 100, 15, 20};

            var arr = new AndArray(x);
            var a = new AndArray(y);
            
            int[] res = arr.Add(a);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.WriteLine("Sqrt for each element: ");
            arr.ForEach();
            arr.ShowType();

            Console.WriteLine("\n\n")
                ;
            var c = new OrArray(x);
            var z = new AndArray(y);
            int[] result = c.Add(z);
            Console.WriteLine("Union: ");
            foreach (var elem in result)
            {
                Console.WriteLine(elem + " ");
            }
            Console.WriteLine("Log for each element: ");
            c.ForEach();
            c.ShowType();
        }
    }
}