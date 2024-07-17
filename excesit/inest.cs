using System;

class Program
{
    static T Identity<T>(T arg)
    {
        return arg;
    }

    static void Main()
    {
        Console.WriteLine(Identity(5));                // Outputs: 5
        Console.WriteLine(Identity("hello"));          // Outputs: hello
        Console.WriteLine(Identity(new int[] { 1, 2, 3 })); // Outputs: System.Int32[]
    }
}
