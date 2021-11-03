/*
 *Реалізувати клас-оболонку Number для числового типу double. Реалізувати
методи множення і віднімання.
Створити похідний клас Real, в якому реалізувати метод, що обчислює корінь
довільного степеня, і метод для обчислення числа π в заданій степені.
 * 
 */


using System;

namespace OOP_lab_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var x = new Number();
            var z = new Number();
            x.Read();
            z.Read();
            x.Display();
            z.Display();
            var d = x + z;
            d.Display();
            d = x * z;
            d.Display();

            var r = new Real();
            var p = new Real();
            r.Read();
            p.Read();
            r.Display();
            p.Display();
            
            Console.WriteLine(r.PowerPi());
            Console.WriteLine("Input root: ");
            var root = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(r.Root(root));
        }
    }
}