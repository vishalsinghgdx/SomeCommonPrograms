using System;
using System.Collections.Generic;

namespace CommonProgram
{
    /// <summary>
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class LargestPalimdrome
    {
        static List<int> data = new List<int>();

        public static void CheckLargestPalimdrome()
        {
            int max = 0;
            for (int i = 999; i > 9; i--)
            {
                for (int j = 999; j > 9; j--)
                {
                    int mul = i * j;                   
                    if (Palindrome.CheckPalimdrome(mul) && (mul > max))
                    {
                        max = mul;
                       // Console.WriteLine("i " + i + ", j " + j);
                       // Console.WriteLine("Found " + max);
                    }
                }
            }

            Console.WriteLine("Largest palimdrome " + max);
        }
    }
}
