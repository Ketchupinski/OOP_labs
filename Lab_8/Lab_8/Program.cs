/*
 * Створити клас Pair (пара чисел); визначити методи зміни полів і обчислення
добутку чисел.
Визначити клас-контейнер RightAngled (прямокутний трикутник), що містить
поле «пара чисел», яке описує катети.
Визначити методи обчислення гіпотенузи і площі трикутника.
 */


using System;

namespace Lab_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var p = new Pair();
            p.Read();
            p.Display();
            Console.WriteLine("Production of p: " + p.Prod());

            var d = new Pair(3, 6);
            Console.WriteLine("d(3, 6)");
            
            var s = p + d;
            Console.WriteLine("s = p + d");
            s.Display();

            s = p - d;
            Console.WriteLine("s = p - d");
            s.Display();

            p++;
            Console.WriteLine("p++");
            p.Display();
            
            p--;
            Console.WriteLine("p--");
            p.Display();

            Console.WriteLine("Objects created: Pair: " + Pair.GetCount() 
                                                        + " RightAngled: " + Pair.RightAngled.GetCount());
            
            var r = new Pair.RightAngled();

            r.Read();
            r.Display();
            Console.WriteLine("Hypotenuse: " + r.getHypotenuse());
            Console.WriteLine("Area: " + r.getArea());

            var z = new Pair.RightAngled(4, 5);
            Console.WriteLine("z(4,5)");

            var k = r + z;
            Console.WriteLine("k = r + z");
            k.Display();
            
            k = r - z;
            Console.WriteLine("k = r - z");
            k.Display();

            r++;
            Console.WriteLine("r++");
            r.Display();

            r--;
            Console.WriteLine("r--");
            r.Display();
            
            Console.WriteLine("Objects created: Pair: " + Pair.GetCount() 
                                                        + " RightAngled: " + Pair.RightAngled.GetCount());

        }
    }
}