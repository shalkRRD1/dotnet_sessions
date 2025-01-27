using System;

public interface SumInterface
{
    int Sum(int[] array);  
}

public abstract class SumAbstract : SumInterface
{
    public abstract int Sum(int[] array);  
}

public class SumClass : SumAbstract
{
    public override int Sum(int[] array)
    {
       int[] arr = new int[10];
	   int[] sum = new int[2];
	   
       Console.Write("Enter the number of elements to be stored in the array: ");
       n = Convert.ToInt32(Console.ReadLine()); 

       for (int i = 0; i < arr.Length-1; i++)
       {
           Console.Write($"Integer[{i}]: ");  
           arr[i] = Convert.ToInt32(Console.ReadLine());  
       }

       for (i = 0; i < arr.Length-1; i++)
       {
		   if(i==0 || i%2==0)
		   {
		   	sum[0] += arr[i]; 
		   }
		   else
		   {
		   	sum[1] += arr[i]; 
		   }
       }
    }
}

class Program
{
    static void Main()
    {
        int[] integers = { 1, 2, 3, 4, 5 };
        int sum = sumArray.Sum(integers);

        SumInterface sumArray = new SumClass();
		Console.Write($"Sum of alternate integers present in the array is : [{sum[0]},{sum[1]}]");
    }
}