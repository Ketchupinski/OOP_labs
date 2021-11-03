// Створити похідний клас Real, в якому реалізувати метод, що обчислює корінь
// довільного степеня, і метод для обчислення числа π в заданій степені.

using System;

namespace OOP_lab_9
{
    public class Real: Number
    {
        public Real()
        {
            this.num = 0;
        }

        public Real(double num)
        {
            this.num = num;
        }

        public Real(Real n)
        {
            this.num = n.num;
        }

        ~Real() {}

        public double PowerPi()
        {
            return Math.Pow(Math.PI, num);
        }

        public double Root(int power)
        {
            return Math.Pow(this.num, 1 / power);
        }
        
        public static
            Number operator *(Real a, Real b)
        {
            return new Number(a.num * b.num);
        }

        public static
            Number operator +(Real a, Real b)
        {
            return new Number(a.num + b.num);
        }
        
    }
}