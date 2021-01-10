using System;
/// <summary>
/// Check for palindrome
/// </summary>
namespace CommonProgram
{
    class Palindrome
    {
        public static bool CheckPalimdrome(int n)
        {
            int sum = 0;
            int r = 0;
            int temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
