using System;

/// <summary>
/// Reverse string
/// </summary>
namespace CommonProgram
{
    class ReverseString
    {
        static string  str = "My name is ram";

        public static void Reverse()
        {
            char temp;
            char[] temp1 = str.ToCharArray();
            int len = temp1.Length;

            for (int i = 0; i < len/2; i++)
            {
                temp = temp1[i];
                temp1[i] = temp1[len - 1 - i];
                temp1[len - 1 - i] = temp;
            }

            Console.WriteLine(string.Join("", temp1));
        }

        public static void Reverse2()
        {
            char[] temp = str.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(string.Join("", temp));
        }

    }
}
