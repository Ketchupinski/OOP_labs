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
    public class Pair
    {
        private int first;
        private int second;
        private static int count = 0;

        public Pair()
        {
            first = 0;
            second = 0;
            count++;
        }

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
            count++;
        }

        public Pair(Pair p)
        {
            this.first = p.first;
            this.second = p.second;
        }

        public static int GetCount()
        {
            return count;
        }
        public int GetFirst()
        {
            return first;
        }

        public int GetSecond()
        {
            return second;
        }

        public void SetFirst(int first)
        {
            this.first = first;
        }

        public void setSecond(int second)
        {
            this.second = second;
        }

        public void Read()
        {
            Console.WriteLine("Input first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            
            var p = new Pair(first, second);
            this.first = p.first;
            this.second = p.second;
        }

        public void Display()
        {
            Console.WriteLine("First: " + this.first);
            Console.WriteLine("Second: " + this.second);
        }

        public int Prod()
        {
            return this.first + this.second;
        }

        public static Pair
            operator ++(Pair p)
        {
            int f = p.first + 1;
            int s = p.second + 1;
            return new Pair(f, s);
        }
        
        public static Pair
            operator --(Pair p)
        {
            int f = p.first - 1;
            int s = p.second - 1;
            return new Pair(f, s);
        }


        public static Pair
            operator -(Pair a, Pair b)
        {
            return new Pair(a.first - b.first, a.second - b.second);
        }

        public static Pair
            operator +(Pair a, Pair b)
        {
            return new Pair(a.first + b.first, a.second + b.second);
        }

        public static String ToString(Pair p)
        {
            String s = "First: " + p.first + "\nSecond: " + p.second;
            return s;
        }

        public class RightAngled
        {
            private static int count = 0;
            private Pair legs;

            public RightAngled()
            {
                this.legs = new Pair();
                count++;
            }

            public RightAngled(int first, int second)
            {
                if (first > 0 && second > 0)
                {
                    this.legs = new Pair(first, second);
                    count++;
                }
                else
                {
                    Console.WriteLine("Legs must be more than 0!");
                }
            }

            public RightAngled(RightAngled r)
            {
                this.legs = r.legs;
            }

            public int GetFirstLeg()
            {
                return legs.first;
            }
            
            public int GetSecondLeg()
            {
                return legs.second;
            }
            
            public void SetFirstLeg(int first)
            {
                this.legs.first = first;
            }
            
            public void SetSecondLeg(int second)
            {
                this.legs.second = second;
            }
            public static int GetCount()
            {
                return count;
            }
            public double getHypotenuse()
            {
                return Math.Sqrt(Math.Pow(legs.first, 2) + Math.Pow(legs.second, 2));
            }

            public double getArea()
            {
                return 0.5 * (legs.first * legs.second);
            }

            public void Read()
            {
                int first = 0, second = 0;
                do
                {
                    Console.WriteLine("Please, input first leg: ");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please, input second leg: ");
                    second = Convert.ToInt32(Console.ReadLine());
                } while (!(first > 0 && second > 0));

                var x = new RightAngled(first, second);
                this.legs = x.legs;
            }

            public void Display()
            {
                Console.WriteLine("First: " + legs.GetFirst() );
                Console.WriteLine("Second: " + legs.GetSecond() );
            }

            public static RightAngled
                operator +(RightAngled a, RightAngled b)
            {
                return new RightAngled(a.legs.first + b.legs.first, a.legs.second + b.legs.second);
            }
            
            public static RightAngled
                operator -(RightAngled a, RightAngled b)
            {
                return new RightAngled(a.legs.first - b.legs.first, a.legs.second - b.legs.second);
            }
            
            public static RightAngled
                operator ++(RightAngled p)
            {
                int f = p.legs.first + 1;
                int s = p.legs.second + 1;
                return new RightAngled(f, s);
            }
            
            public static RightAngled
                operator --(RightAngled p)
            {
                int f = p.legs.first - 1;
                int s = p.legs.second - 1;
                return new RightAngled(f, s);
            }
            
            public static String ToString(RightAngled p)
            {
                String s = "First: " + p.legs.first + "\nSecond: " + p.legs.second;
                return s;
            }
            
        }
    }
}