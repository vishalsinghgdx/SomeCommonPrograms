using System;
/// <summary>
/// Selection sort, Time complexity O(n^2), Space complexity O(1)
/// </summary>
namespace CommonProgram
{
    class ArraySorting
    {
        public static void Sorting()
        {
            int[] arr = { 3, 9, 1, 4, 2, 0, 54, 16, 3 };

            int len = arr.Length;

            Console.WriteLine("Before sorting...");

            for(int i = 0; i < len; i++)
            {
                Console.Write(arr[i]+" ,");
            }
            Console.WriteLine("");

            for (int i = 0; i < len; i++)
            {
                for(int j = i+1; j < len; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting");

            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i]+" ,");
            }
        }
    }
}
