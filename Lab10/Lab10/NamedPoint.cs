using System;
using System.Configuration;

namespace Lab10
{
    public class NamedPoint : Point

    {
        private string name;
        
        private bool CheckPointName(string _name)
        {
            if (_name.Length != 1)
            {
                return false;
            }

            return true;
        }

        private void ToCorrectName(string _name)
        {
            char[] ar = _name.ToCharArray();
            this.name = ar[0].ToString().ToUpper();
        }
        
        public NamedPoint()
        {
            name = null;
            SetX(0);
            SetY(0);
        }

        public NamedPoint(string name, int x, int y)
        {
            this.name = name;
            SetX(x);
            SetY(y);
        }

        public NamedPoint(Point p, string name)
        {
            this.name = name;
            SetX(p.GetX());
            SetY(p.GetY());
        }

        public NamedPoint(NamedPoint n)
        {
            this.name = n.name;
            SetX(n.GetX());
            SetY(n.GetY());
        }

        public void SetName(string name)
        {
            if (CheckPointName(name))
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Point name must have only one letter! Program set first letter as name!");
                ToCorrectName(name);
            }
        }

        public string GetName()
        {
            return name;
        }

        public void Read()
        {
            Console.WriteLine("Input x: ");
            SetX(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input y: ");
            SetY(Convert.ToInt32(Console.ReadLine()));

            string _name;
            do
            {
                Console.WriteLine("Input point name: ");
                _name = Console.ReadLine();
            } while (!(CheckPointName(_name)));

            name = _name.ToUpper();
        }

        public void Display()
        {
            int x = GetX();
            int y = GetY();
            Console.WriteLine("Point coordinates: [{0}; {1}]", x, y);
            Console.WriteLine("Point name: " + name);
        }

        public void ChangePointName()
        {
            Console.WriteLine("Input new point name(one big letter): ");
            string _name = Console.ReadLine();
            
            if (!(CheckPointName(_name)))
            {
                Console.WriteLine("Point name must have only one letter! Program set first letter as name!");
                ToCorrectName(_name);
            }
        }
    }


}