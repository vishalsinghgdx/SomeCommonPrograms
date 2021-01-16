using System;
using System.Collections;
using System.Collections.Generic;

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

            //CustomArray array = new CustomArray(3);
            //array.Insert(10);
            //array.Insert(15);
            //array.Insert(20);
            //array.Insert(25);
            //array.Insert(30);
            //array.ItemAtIndex(4);
            //Console.WriteLine(array.IndexOf(50));
            //array.RemoveAt(1);
            // array.Print();

            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //foreach(var l in list)
            //{
            //    Console.WriteLine(l);
            //}

            //LinkedList<int> linked = new LinkedList<int>();

            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(5);
            linkedList.AddLast(25);
            //Console.WriteLine(linkedList.IndexOf(25));
            //Console.WriteLine(linkedList.Contains(50));
            linkedList.RemoveFirst();
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            Console.ReadLine();
        }
    }
}
