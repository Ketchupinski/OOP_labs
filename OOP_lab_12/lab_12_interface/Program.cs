namespace lab_12_interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var c = new ComplexNumbers(1, 5, 8, 2);
            c.Add();
            c.ShowType();

            int[] vOne = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] vTwo = new[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            var v = new Vectors(vOne, vTwo);
            v.Add();
            v.ShowType();

            int[,] mOne = new int[2, 2];
            int[,] mTwo = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mOne[i, j] = i;
                    mTwo[i, j] = j;
                }
            }

            var m = new Matrices(mOne, mTwo);
            m.Add();
            m.ShowType();
        }
    }
}