using Assignment_day25.Models;
using System;
using System.Numerics;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        var acc1 = new Account("SS", 10000);
        PrintDetails(acc1);

        var acc2 = new Account("SSS", 5000);
        PrintDetails(acc2);

        Account tx = acc1.CanYouTransfer(acc2);
        PrintDetails(tx);
    }
    private static void PrintDetails(Account acc)
    {
        Console.WriteLine($"Player Name: {(acc.Name == null ? "Null" : acc.Name)}");
        Console.WriteLine($"Player Amt: {acc.Amt}");
        Console.WriteLine($"hashcode is {acc.GetHashCode()}");
        Console.WriteLine();

    }
}