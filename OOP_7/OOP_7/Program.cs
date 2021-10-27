using System;

namespace OOP_7
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            
            Matrix a = Matrix.Create();
            a.Fill();
            a.Display();

            Matrix b = Matrix.Create();
            b.Fill();
            b.Display();
            
            Console.WriteLine("a - b: ");
            var z = a - b;
            z.Display();
            
            Console.WriteLine("\na == b: {0}\n", a == b);
            Console.WriteLine("\na != b: {0}\n", a != b);

            Console.WriteLine("Matrix norm from matrix a: {0}", a.Norm());
            

            Set s = new Set();
            s.Fill();
            s.Display();
            s.Add(5);
            s.Display();
            s.Delete(5);
            s.Display();
            Console.WriteLine("\n\nIs number 231 in set: {0}", s.Check(231));
            Console.WriteLine("\n\nCount numbers in set: {0}", s.Count());
            var x = new Set();
            x.Fill();
            x.Display();
            var c = new Set();
            Console.WriteLine("Cross Sets: ");
            c = c.СrossSets(x, s);
            c.Display();

            Console.WriteLine("Union Sets: ");
            c = c.UnionSets(x, s);
            c.Display();

            Console.WriteLine("Set x minus set s: ");
            c = x - s;
            c.Display();
            
            Console.WriteLine("x == s: {0}", x == s );
            Console.WriteLine("x == s: {0}", x != s );
            


        }
    }
}