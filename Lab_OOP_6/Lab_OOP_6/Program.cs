using System;

namespace Lab_OOP_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Fraction f = new Fraction();
            f.Read();
            
            
            f++;
            Console.WriteLine("f++:\n  x: {0} | y: {1}", f.getX(), f.getY());
            ++f;
            Console.WriteLine("++f:\n  x: {0} | y: {1}", f.getX(), f.getY());
            f--;
            Console.WriteLine("f--:\n  x: {0} | y: {1}", f.getX(), f.getY());
            --f;
            Console.WriteLine("--f:\n  x: {0} | y: {1}", f.getX(), f.getY());

            Fraction frac = new Fraction();
            frac.Read();

            Fraction result = f - frac;
            Console.WriteLine("'f - frac':\n x: {0} | y: {1}", result.getX(), result.getY());

            bool answ;
            
            answ = f > frac;
            Console.WriteLine("\n'f > frac': {0}", answ);
            
            answ = f < frac;
            Console.WriteLine("\n'f < frac': {0}", answ);
            
            answ = f <= frac;
            Console.WriteLine("\n'f <= frac': {0}", answ);
            
            answ = f >= frac;
            Console.WriteLine("\n'f >= frac': {0}", answ);
            
            answ = f == frac;
            Console.WriteLine("\n'f == frac': {0}", answ);
            
            answ = f != frac;
            Console.WriteLine("\n'f != frac': {0}", answ);

        }
    }
}