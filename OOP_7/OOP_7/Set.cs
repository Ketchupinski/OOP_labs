using System;

/*
 *Реалізувати клас Set (множина) не більше ніж з 256 елементів-символів.
Потрібно забезпечити включення елементу у множину, вилучення елементу із
множини, об’єднання, перетин і різницю множин, обчислення кількості елементів в
множині, перевірку наявності елемента у множині, перевірку входження однієї
множини у іншу.
*/

using System.ComponentModel.Design;
using System.Globalization;

namespace OOP_7
{
    public class Set
    {
        private const int size = 256;
        private int[] set = new int[size];

        public Set()
        {
            for (int i = 0; i < size; i++)
            {
                this.set[i] = 0;
            }
        }

        private Set(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0 && num[i] < 256)
                {
                    this.set[num[i]] = 1;
                }
            }
        }

        public void Fill()
        {
            int[] numbers = new int[4];
            int x = 0, i = 0;
            Console.WriteLine("Hi, throw me some numbers to put them into set!\n");
            do
            {
                Console.Write("Number from 0 to 255: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x >= 0 && x < 256)
                {
                    numbers[i] = x;
                    i++;
                }
                else
                {
                    Console.WriteLine("Please, input argument in range 0 - 255!");
                }
            } while (i <= 3);

            Set z = new Set(numbers);
            this.set = z.set;
            Console.WriteLine("\n");
        }

        public void Display()
        {
            Console.WriteLine("Set: ");
            for (int i = 0; i < size; i++)
            {
                if (set[i] == 1)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine("\n");
        }

        public void Add(int num)
        {
            if (num >= 0 && num < 256)
            {
                set[num] = 1;
                Console.WriteLine("Succesfully added number to set!");
            }
            else
            {
                Console.WriteLine("Error! Number must be in range from 0 to 255!");
            }
        }

        public void Delete(int num)
        {
            if (num >= 0 && num < 256)
            {
                set[num] = 0;
                Console.WriteLine("Succesfully delete number from set!");
            }
            else
            {
                Console.WriteLine("Error! Number must be in range from 0 to 255!");
            }
        }

        public bool Check(int num)
        {
            if (set[num] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Count()
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (set[i] == 1)
                {
                    sum++;
                }
            }

            return sum;
        }

        public Set UnionSets(Set a, Set b)
        {
            var c = new Set();
            for (int i = 0; i < size; i++)
            {
                if (a.set[i] == 1 || b.set[i] == 1)
                {
                    c.set[i] = 1;
                }
            }
            return c;
        }
        
        public Set СrossSets(Set a, Set b)
        {
            var c = new Set();
            for (int i = 0; i < size; i++)
            {
                if (a.set[i] == 1 && b.set[i] == 1)
                {
                    c.set[i] = 1;
                }
            }
            return c;
        }

        static public Set
            operator -(Set a, Set b)
        {
            var c = new Set();
            for (int i = 0; i < size; i++)
            {
                if (a.set[i] == 1 && b.set[i] == 0)
                {
                    c.set[i] = 1;
                }
            }

            return c;
        }

        static public bool
            operator ==(Set a, Set b)
        {
            for (int i = 0; i < size; i++)
            {
                if (a.set[i] == 1 && b.set[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        static public bool
            operator !=(Set a, Set b)
        {
            for (int i = 0; i < size; i++)
            {
                if (a.set[i] == 1 && b.set[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
    
}