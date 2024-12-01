using System;

class Program
{
    static void DoSomeThing(int seconds, string message)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine($"{message} {i}");
            Thread.Sleep(1000);

        }
    }
    static void Main(string[] args)
    {
        DoSomeThing(5, "Hello World");
        Console.WriteLine("Hello World"); 
    }
}
