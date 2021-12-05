namespace lab_12_interface
{
    public class Matrices : IAdd
    {
        private int[,] MatrixOne { get; set; }
        private int[,] MatrixTwo { get; set; }

        public Matrices()
        {
            MatrixOne = new int[2, 2];
            MatrixTwo = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MatrixOne[i, j] = 0;
                    MatrixTwo[i, j] = 0;
                }
            }
        }

        public Matrices(int[,] one, int[,] two)
        {
            MatrixOne = one;
            MatrixTwo = two;
        }


        public void Add()
        {
            int[,] mResult = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mResult[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
                }
            }
            
            System.Console.WriteLine("Result: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.Write(mResult[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        
        public void ShowType()
        {
            System.Console.WriteLine("Object type: " + GetType().Name);
        }
    }
}