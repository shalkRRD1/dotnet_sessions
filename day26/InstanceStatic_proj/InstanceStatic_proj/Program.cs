using System;
using InstanceStatic_proj.Models;

namespace InstanceStatic_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static prorperty
            Console.ForegroundColor = ConsoleColor.Red;

            var abc = new Account(101, "Abc",2000);
            Console.WriteLine(abc.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.ResetColor();//staic method

            new Account(102, "Xyz", 1000);
            Console.WriteLine(abc.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            new Account(103, "Axyz",3000);
            Console.WriteLine(abc.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.WriteLine(Account.HeadCount);

        }
    }
}
