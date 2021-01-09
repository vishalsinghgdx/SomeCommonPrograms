using System;

namespace CommonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestDivisible();
            Console.ReadLine();
        }

        static void SmallestDivisible()
        {
            // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            int max = 20;
            int SN = max;
            int div = 2;

            while (div < max)
            {
                if (SN % div == 0)
                {
                    div += 1;
                    if (div == max)
                    {
                        Console.WriteLine(SN);
                    }
                }
                else
                {
                    SN = SN + max;
                    div = 2;
                }
            }
        }
    }
}
