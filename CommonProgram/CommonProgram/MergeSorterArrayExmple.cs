using System;

namespace CommonProgram
{
    public class MergeSorterArrayExmple
    {
        // [0, 3, 4, 31], [4, 6, 30]
        public static void MergeSorterdArray(int[] arr1, int[] arr2)
        {
            int[] mergedArray;
            int len1 = arr1.Length;
            int len2 = arr2.Length;

            if (len1 == 0)
            {
                mergedArray = arr2;
                for (int i = 0; i < mergedArray.Length; i++)
                {
                    Console.WriteLine(mergedArray[i]);
                }
                return;
            }
                
            if (len2 == 0)
            {
                mergedArray = arr1;
                for (int i = 0; i < mergedArray.Length; i++)
                {
                    Console.WriteLine(mergedArray[i]);
                }
                return;
            }
                

            int maxLenght = len1 > len2 ? len1 : len2;
            mergedArray = new int[len1 + len2];

            int l = 0;
            int r = 0;

            for (int i = 0; i < (len1 + len2); i++)
            {              
                if (arr1[l] <= arr2[r])
                {
                    mergedArray[i] = arr1[l];
                    l++;
                    Console.WriteLine("l " + l);
                }
                else if(arr1[l] > arr2[r])
                {
                    mergedArray[i] = arr2[r];
                    r++;
                    Console.WriteLine("r " + r);
                }
            }

           for(int i = 0; i < mergedArray.Length; i++)
           {
               Console.WriteLine(mergedArray[i]);
           }
        }
    }
}
