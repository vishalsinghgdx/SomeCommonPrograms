using System;

namespace Simple_Programming_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapTwoNumbers obj = new SwapTwoNumbers();
            obj.SwapWithThirdNum(1, 2);
            obj.SwapWithoutThirdNum(100, 250);
        }
    }

    /// <summary>
    /// Program of swapping 2 numbers
    /// </summary>
    public class SwapTwoNumbers
    {
        public void SwapWithThirdNum(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Swapped numbers are: {a} , {b}");
        }

        public void SwapWithoutThirdNum(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Swapped numbers are: {a} , {b}");
        }
    }
}
