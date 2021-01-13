using System;

/// <summary>
/// Program for reversing a string
/// </summary>
namespace CommonProgram
{
    class ReverseString
    {
        static string[] names = { "AA", "BB", "CC", "DD", "EE", "FF" };

        /// <summary>
        /// Reverse string by storing in temporary array
        /// </summary>
        public static void ReverseByStoring()
        {
            Console.WriteLine("Reversing........");
            int len = names.Length;
            string[] temp = new string[len];

            for(int i = 0; i < len; i++)
            {
                temp[i] = names[len - 1 - i];
            }

            Console.WriteLine("Before reversign...");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("After reversign...");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }

        // Reverses string by swapping
        public static void ReverseBySwapping()
        {
            string temp = "";
            int len = names.Length;
            for(int i = 0; i < len/2; i++)
            {
                temp = names[i];
                names[i] = names[len - 1 - i];
                names[len - 1 - i] = temp;
            }

            for(int i = 0; i < len; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
