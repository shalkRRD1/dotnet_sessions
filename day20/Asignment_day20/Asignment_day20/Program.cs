using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? name = null;
        findValidName(name);
    }

    static void findValidName(string name)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Please type a valid name:");
            name = Console.ReadLine();
            string pattern = @"\d|\s|\W";
            Regex rg = new Regex(pattern);
            if (rg.IsMatch(name))
            {
                Console.WriteLine($"Hey!!! {name} not a valid name");
            }
            else
            {
                Console.WriteLine($"{name} is a valid name. Thank You!");
                flag = false;
            }
        }
    }
}