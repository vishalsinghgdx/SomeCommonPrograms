namespace CommonProgram
{
    class PrimeNumber
    {
        public static void CheckPrime(int n)
        {
            int i = 2;
            while(n > i)
            {
                if(n % i == 0)
                {
                    System.Console.WriteLine(n + " is not a Prime number");
                    return;
                }
                i++;
            }
            System.Console.WriteLine(n + " is a Prime number");
        }
    }
}
