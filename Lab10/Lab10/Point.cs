// Створити клас точка, що має координати. Визначити конструктори, деструктор і
// функцію виведення


using System;

namespace Lab10
{
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        ~Point()
        {
            x = 0;
            y = 0;
        }

        public void SetX(int x)
        {
            this.x = x;
        }
        
        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void Read()
        {
            Console.WriteLine("Input x: ");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y: "); 
            this.y = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Display()
        {
            Console.WriteLine("Point coordinates: [{0}; {1}]", x, y);
        }

        public void MovePointUp()
        {
            y++;
        }
        
        public void MovePointDown()
        {
            y--;
        }
        
        public void MovePointRight()
        {
            x++;
        }

        public void MovePointLeft()
        {
            x--;
        }

        public void ChangePointPosition(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }
    
    
}