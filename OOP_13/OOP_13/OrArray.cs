using System;
using System.Linq;

namespace OOP_13
{
    public class OrArray : BArray
    {
        public OrArray(int[] a) : base(a)
        {}

        public override int[] Add(BArray a)
        {
            int[] r = Array.Union(a.Array).ToArray();
            return r;
        }
        public override void ForEach()
        {
            foreach (var elem in Array)
            {
                Console.WriteLine(Math.Log(elem));
            }
        }


    }
}