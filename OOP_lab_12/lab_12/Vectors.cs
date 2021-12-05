namespace lab_12
{
    public class Vectors : ABase
    {
        private int[] V1 { get; set; }
        private int[] V2 { get; set; }

        public Vectors()
        {
            V1 = new int[10];
            V2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                V1[i] = 0;
                V2[i] = 0;
            }
        }

        public Vectors(int[] vOne, int[] vTwo)
        {
            if (vOne.Length == 10 && vTwo.Length == 10)
            {
                V1 = vOne;
                V2 = vTwo;
            }
        }

        public override void Add()
        {
            int[] vResult = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vResult[i] = V1[i] + V2[i];
            }
            
            System.Console.Write("Result: [");
            for (int i = 0; i < 9; i++)
            {
                System.Console.Write(vResult[i] + ", ");
            }
            System.Console.WriteLine(vResult[9] + "]");
        }
    }

}