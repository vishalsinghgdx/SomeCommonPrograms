using System;

namespace CommonProgram
{
    /// <summary>
    /// Given and integer array and a target number. Find the numbers whose sum of indeces is equal to target
    /// Run time complexity is O(n)
    /// </summary>
    public class TwoSum
    {
        int[] nums = new int[] { 2, 7, 15, 19 };
        int target = 22;

        public void FindSums()
        {
            for(int i = 0; i < nums.Length-1; i++)
            {
                if((nums[i]+nums[i+1]) == target)
                {
                    Console.WriteLine("numbers is: " + nums[i] + " , " + nums[i+1]);
                    return;
                }
            }
            Console.WriteLine("Numbers not found");
        }
    }
}
