// кольорова точка, що має колір

using System;

namespace Lab10
{
    public enum Colors
    {
        Black,
        Red, 
        Green, 
        Blue, 
        White,
        Yellow
    }
    public class ColoredPoint: Point
    {
        private Colors color;

        public ColoredPoint()
        {
            SetX(0);
            SetY(0);
            color = 0;
        }

        public ColoredPoint(Colors c, int x, int y)
        {
            SetX(x);
            SetY(y);
            color = c;
        }

        public ColoredPoint(Point p, Colors c)
        {
            SetX(p.GetX());
            SetY(p.GetY());
            color = c;
        }

        public ColoredPoint(int colorNum, int x, int y)
        {
            if (colorNum >= 0 && colorNum <= 5)
            {
                color = (Colors)colorNum;
            }
            else
            {
                Console.WriteLine("Wrong argument given, color has set to Black!");
                color = 0;
            }

            SetX(x);
            SetY(y);
        }

        public ColoredPoint(ColoredPoint p)
        {
            this.color = p.color;
            int x = p.GetX();
            int y = p.GetY();
            this.SetX(x);
            this.SetY(y);
        }

        ~ColoredPoint()
        {
            SetX(0);
            SetX(0);
            color = 0;
        }

        void SetColor(Colors color)
        {
            this.color = color;
        }

        Colors GetColor()
        {
            return color;
        }

        public void ColorMenu()
        {
            int choise = 0;
            do
            {
                Console.WriteLine("Input number of color, that you need:\n" +
                                  "0-Black\n1-Red\n2-Green\n3-Blue\n4-White\n5-Yellow");
                choise = Convert.ToInt32(Console.ReadLine());
            } while (!(choise >= 0 && choise <= 5));
            this.color = (Colors) choise;
        }

        public void Read()
        {
            int _x, _y;
            Console.WriteLine("Input x: ");
            _x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y: ");
            _y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            ColorMenu();

            SetX(_x);
            SetY(_y);
        }

        public void Display()
        {
            int x = GetX();
            int y = GetY();
            Console.WriteLine("Point coordinates: [{0}; {1}]", x, y);
            Console.WriteLine("Point color: " + color); 
        }
    }
}