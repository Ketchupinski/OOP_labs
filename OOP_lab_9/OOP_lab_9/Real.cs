// Створити похідний клас Real, в якому реалізувати метод, що обчислює корінь
// довільного степеня, і метод для обчислення числа π в заданій степені.

using System;

namespace OOP_lab_9
{
    public class Real: Number
    {
        public Real()
        {
            SetNum(0);
        }

        public Real(double num)
        {
            SetNum(num);
        }

        public Real(Real n)
        {
            this.SetNum(n.GetNum());
        }

        ~Real()
        {
            SetNum(0);
        }

        public double PowerPi()
        {
            return Math.Pow(Math.PI, GetNum());
        }

        public double Root(double power)
        {
            return Math.Pow(this.GetNum(), 1 / power);
        }
        
        public static
            Real operator *(Real a, Real b)
        {
            return new Real(a.GetNum() * b.GetNum());
        }

        public static
            Real operator -(Real a, Real b)
        {
            return new Real(a.GetNum() + b.GetNum());
        }
        
    }
}