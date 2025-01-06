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
    }
}
