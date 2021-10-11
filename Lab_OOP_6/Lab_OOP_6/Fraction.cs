/*
Створити клас Fraction для роботи з дробовими числами. Число має бути
представлене двома полями:
• ціла частина – довге ціле із знаком,
• дробова частина – без-знакове коротке ціле.
Реалізувати методи – арифметичні операції:
• віднімання,
• операції порівняння.
*/

using System;


namespace Lab_OOP_6
{
    public class Fraction
    { 
        private long x; // numerator
        private ushort y; // dominator

        public Fraction()
        {
            x = 1;
            y = 1;
        }

        public Fraction(long x, ushort y)
        {
            if (y == 0)
            {
                Console.WriteLine("y can't be 0! Changed to 1");
                y = 1;
            }
            this.x = x;
            this.y = y;
        }

        public Fraction(Fraction f)
        {
            f.x = this.x;
            f.y = this.y;
        }

        ~Fraction()
        {
            x = 0;
            y = 0;
        }
        public long getX()
        {
            return x;
        }

        public ushort getY()
        {
            return y;
        }

        public void setX(long x)
        {
            this.x = x;
        }

        public void setY(ushort y)
        {
            this.y = y;
        }

        public void Read()
        {
            // x
            Console.WriteLine("x: ");
            long x = Convert.ToInt64(Console.ReadLine());
            this.x = x;
            
            // y
            ushort y;
            do
            {
                Console.WriteLine("y: ");
                y = Convert.ToUInt16(Console.ReadLine());
            } while (y == 0);

            this.y = y;
        }
        
        public static Fraction
            operator ++(Fraction f)
        {
            return new Fraction(f.x + f.y, f.y);
        }

        public static Fraction
            operator --(Fraction f)
        {
            return new Fraction(f.x - f.y, f.y);
        }

        public static Fraction
            operator -(Fraction a, Fraction b)
        {
            long num = (a.x * b.y) - (a.y * b.x);
            int denom = a.y * b.y;
            return new Fraction(num, Convert.ToUInt16(denom));
        }

        public static bool
            operator >(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 > n2)
            {
                return true;
            }
            return false;
            
        }
        
        public static bool
            operator <(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 < n2)
            {
                return true;
            }
            return false;
            }
        
        public static bool
            operator <=(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 <= n2)
            {
                return true;
            }
            return false;

        }
        
        public static bool
            operator >=(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 >= n2)
            {
                return true;
            }
            return false;
            
        }
        
        public static bool
            operator ==(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 == n2)
            {
                return true;
            }
            return false;
            
        }
        
        public static bool
            operator !=(Fraction a, Fraction b)
        {
            double n1 = a.x / a.y;
            double n2 = b.x / b.y;
            if (n1 != n2)
            {
                return true;
            }
            return false;
            
        }
        
        
    }
}