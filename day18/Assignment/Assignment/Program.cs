using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Length of command line arguments: " + args.Length);

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Value: {args[i]}");
        }

        foreach (string a in args)
        {
            Console.WriteLine($"Value: {a}");
        }

        //Reverse
        Console.WriteLine("Reverse Array");

        for (int i = args.Length; i > 0; i--)
        {
            Console.WriteLine($"Value: {args[i]}");
        }

    }

}
