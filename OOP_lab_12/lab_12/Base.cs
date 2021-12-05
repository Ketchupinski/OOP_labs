using System;

namespace lab_12
{
    public abstract class ABase
    {
        public abstract void Add();

        public void ShowType()
        {
            Console.WriteLine("Object type: " + GetType().Name);
        }
    }
}