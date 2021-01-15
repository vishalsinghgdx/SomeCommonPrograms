using System;

namespace CommonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //SmallestPostionNumber.SmallestDivisible();
            //LargestPalimdrome.CheckLargestPalimdrome();
            //SumSquareDifference.FindSumSquareDifference(100);
            //PrimeNumber.CheckPrime(421);
            //FindNthPrime.Prime(20);
            //ReverseString.ReverseByStoring();
            //ReverseStringArray.ReverseBySwapping();

            //ReverseString.Reverse();
            //ReverseString.Reverse2();

            CustomArray array = new CustomArray(3);
            array.Insert(10);
            array.Insert(15);
            array.Insert(20);
            array.Insert(25);
            array.Insert(30);
            array.ItemAtIndex(4);
            Console.WriteLine(array.IndexOf(50));
            //array.RemoveAt(1);
            array.Print();

            Console.ReadLine();
        }
    }
}
