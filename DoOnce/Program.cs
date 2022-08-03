using System;

class Program
{
    static void Main(string[] args)
    {
        var caller = new DoOnce(() => Console.WriteLine("Hello, world!"));
        caller.Run();
        caller.Run();
        caller.Run();
    }
}