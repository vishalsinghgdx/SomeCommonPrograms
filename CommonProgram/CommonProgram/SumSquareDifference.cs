using System;
/// <summary>
/// The sum of the squares of the first ten natural numbers is,
/// The square of the sum of the first ten natural numbers is,
/// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
/// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
/// </summary>
namespace CommonProgram
{
    class SumSquareDifference
    {
        static int SumOfSquares(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum = sum + n * n;
                n = n - 1;
            }
            return sum;
        }

        static int SquareOfSum(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum = sum + n;
                n = n - 1;
            }
            return sum * sum;
        }


        public static void FindSumSquareDifference(int n)
        {
            Console.WriteLine(SquareOfSum(n) - SumOfSquares(n));
        }
    }

}
