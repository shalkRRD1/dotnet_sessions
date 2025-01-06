using System;
class Program
{
    static void Main()
    {
        PrintName("Shalini", 4);       
    }
    static int PrintName(string userName, int iterations)
    {
        if (iterations > 0)
        {
            Console.WriteLine($"Hello {userName.ToUpper()}! {iterations}");
            iterations--;
            return PrintName(userName, iterations);
        }
        else
            return 0;
    }
}