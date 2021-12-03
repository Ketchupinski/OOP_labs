/*
 Створити клас точка, що має координати. Визначити конструктори, деструктор і
функцію виведення Створити public-похідні класи – кольорова точка, що має колір,
геометрична точка, що має назву (велика латинська літера). Визначити конструктори
за умовчанням і з різним числом параметрів, деструктор, функцію виведення.
Визначити функції перепризначення кольору і назви точки, виведення точки на екран.
 */

using System;

namespace Lab10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p = new Point();
            p.Read();
            Console.WriteLine();
            p.Display();
            Console.WriteLine();
            
            p.ChangePointPosition(5, 2);
            p.Display();
            
            Console.WriteLine("\nPoint move to right: ");
            p.MovePointRight();
            p.Display();
            
            Console.WriteLine("\nPoint move to down: ");
            p.MovePointDown();
            p.Display();

            Console.WriteLine("\n");
            
            Console.WriteLine("Colored point:");
            var cp = new ColoredPoint();
            cp.Read();
            Console.WriteLine();
            cp.Display();
            
            Console.WriteLine("\nColored point move to up: ");
            cp.MovePointUp();
            cp.Display();
            
            Console.WriteLine("\n");
            
            Console.WriteLine("Named point:");
            var np = new NamedPoint();
            
            np.Read();
            Console.WriteLine();
            np.Display();
            
            Console.WriteLine("\nColored point move to left: ");
            np.MovePointLeft();
            np.Display();
            
            Console.WriteLine("\nChanging point name: ");
            np.ChangePointName();
            np.Display();
        }
    }
}