/*Реалізувати клас-оболонку Number для числового типу double. Реалізуватиметоди множення і віднімання.*/

using System;

namespace OOP_lab_9 {
    public class Number
    {
        private double num;

        public Number()
        {
            num = 0;
        }

        public Number(double num)
        {
            this.num = num;
        }

        public Number(Number n)
        {
            this.num = n.num;
        }

        ~Number()
        {
            num = 0;
        }

        public void SetNum(double num)
        {
            this.num = num;
        }

        public double GetNum()
        {
            return this.num;
        }

        public void Read()
        {
            Console.WriteLine("Input double number: ");
            double read = Convert.ToDouble(Console.ReadLine());
            var temp = new Number(read);
            this.num = temp.num;
        }

        public void Display()
        {
            Console.WriteLine("Double number: " + this.num);
        }

        public static
            Number Multiply(Number a, Number b)
        {
            return new Number(a.num * b.num);
        }

        public static
            Number Add(Number a, Number b)
        {
            return new Number(a.num + b.num);
        }

        public static
            Number operator *(Number a, Number b)
        {
            return new Number(a.num * b.num);
        }

        public static
            Number operator -(Number a, Number b)
        {
            return new Number(a.num - b.num);
        }
    }

}