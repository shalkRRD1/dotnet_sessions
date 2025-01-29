using System;

public interface ReverseInterface
{
    string[] Reverse(string[] array);
}

public abstract class ReverseAbstract : ReverseInterface
{
    public abstract string[] Reverse(string[] array);
}

public class ReverseClass : ReverseAbstract
{
    public override string[] Reverse(string[] array)
    {
        //string[] arr = new string[10];
        string reverseTemp = "";
        for (int i = 0; i < array.Length / 2; i++)
        {
            //Console.WriteLine($"Value: {i}");
            reverseTemp = array[i];
            array[i] = array[(array.Length - i) - 1];
            array[array.Length - i - 1] = reverseTemp;
        }
        return array;
    }
}

class Program
{
    static void Main()
    {
        string[] str = { "abc", "pqr", "lmno", "xyz", "aaa" };
        ReverseInterface reverseArray = new ReverseClass();
        string[] reversed = reverseArray.Reverse(str);
        Console.WriteLine("Reverse of strings present in the array is :");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.WriteLine(reversed[i]);
        }
    }
}