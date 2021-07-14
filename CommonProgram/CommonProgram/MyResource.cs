using System;

public class MyResource : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Dispose all resources...");
    }

    public void DoSomeTask()
    {
        Console.WriteLine("Starting some task...");

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Doing some task...");
        }
    }
}
