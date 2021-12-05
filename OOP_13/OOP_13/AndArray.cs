using System;

namespace OOP_13
{
    public class AndArray : BArray
    {
        public AndArray(int[] a) : base(a)
        {
        }

        public override int[] Add(BArray a)
        {
            if (CheckSet(this.Array) && CheckSet(a.Array)) {
                int maxLen = 0;

                if (this.Array.Length > a.Array.Length)
                {
                    maxLen = this.Array.Length;
                }
                else
                {
                    maxLen = a.Array.Length;
                }

                int[] rArray = new int[maxLen];
                int rNum = 0;

                for (int i = 0; i < this.Array.Length; i++)
                {
                    int check = this.Array[i];
                    for (int j = 0; j < a.Array.Length; j++)
                    {
                        if (check == a.Array[j])
                        {
                            rArray[rNum] = a.Array[j];
                            rNum++;
                        }
                    }
                }

                int[] result = new int[rNum];
                for (int i = 0; i < rNum; i++)
                {
                    result[i] = rArray[i];
                }
                return result;
            }
            else
            {
                Console.WriteLine("Wrong arrays given!");
                int[] wrong = new int[] {0};
                return wrong;
            }
        }
        public override void ForEach()
        {
            Console.WriteLine("Square root: ");
            for (int i = 0; i < this.Array.Length; i++)
            {
                Console.WriteLine(Math.Sqrt(this.Array[i]) + " ");
            }
        }
    }
}