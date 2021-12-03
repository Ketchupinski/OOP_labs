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
            Console.WriteLine("Number x:");
            x.Read();
            x.Display();
            
            Console.WriteLine();
            var z = new Number();
            Console.WriteLine("Number z:");
            z.Read();
            z.Display();
            
            Console.WriteLine("\nx - z:");
            var d = x - z;
            d.Display();
            
            Console.WriteLine("\nx * z");
            d = x * z;
            d.Display();

            Console.WriteLine("\nReal number r:");
            var r = new Real();
            r.Read();
            r.Display();
            
            
            Console.WriteLine("\nPowerPi: " + r.PowerPi());
            
            Console.WriteLine("\nInput root: ");
            var root = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(r.Root(root));
        }
    }
}