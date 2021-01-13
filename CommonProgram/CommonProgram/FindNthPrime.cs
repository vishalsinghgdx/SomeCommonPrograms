using System;
/// <summary>
/// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
/// What is the 10 001st prime number?
/// </summary>
namespace CommonProgram
{
    class FindNthPrime
    {
        public static void Prime(int count) // 13
        {
            for (int n = 2; n < count+1; n++)
            {
                CheckPrime(n);
            }
        }

        static int CheckPrime(int n)
        {
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    return 0;
                }
                i++;
            }
            Console.WriteLine(n);
            return n;
        }

    }
}
