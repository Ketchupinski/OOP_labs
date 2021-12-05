﻿namespace lab_12
{
    public class ComplexNumbers : ABase
    {
        private int FirstReal { get; set; }
        private int FirstImagine { get; set; }
        private int SecondReal { get; set; }
        private int SecondImagine { get; set; }

        public ComplexNumbers()
        {
            FirstReal = 0;
            FirstImagine = 0;
            SecondReal = 0;
            SecondImagine = 0;
        }
        
        public ComplexNumbers(int fReal, int fImagine, int sReal, int sImagine)
        {
            FirstReal = fReal;
            FirstImagine = fImagine;
            SecondReal = sReal;
            SecondImagine = sImagine;
        }
        
        
        public override void Add()
        {
            int resultReal = FirstReal + SecondReal;
            int resultImagine = SecondImagine + FirstImagine;
            System.Console.WriteLine("Result: \nReal: " + resultReal + "\nImagine: " + resultImagine);
        }
    }
}