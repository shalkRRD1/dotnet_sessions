<<<<<<< HEAD
using System;
namespace Assignment_day31
=======
﻿using System;
public interface SumInterface
>>>>>>> 5aa3c217801f5638e0e6f7c910b93b9a48e71395
{
    public interface SumInterface
    {
<<<<<<< HEAD
        void Sum(int[] array);
    }

    public abstract class SumAbstract : SumInterface
    {
        public abstract void Sum(int[] array);
=======
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
>>>>>>> 5aa3c217801f5638e0e6f7c910b93b9a48e71395
    }

    public class SumClass : SumAbstract
    {
        public override void Sum(int[] array)
        {
            int[] sumarr = new int[2];
            //Console.Write("Enter the number of elements to be stored in the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                //int[] sumarr = new int[2];
                //int sumOdd = 0;
                if (i == 0 || i % 2 == 0)
                {
                    sumarr[0] += array[i];
                }
                else
                {
                    sumarr[1] += array[i];
                }
            }
            Console.Write($"Value array: {sumarr[0]} and {sumarr[1]}");
        }
    }
<<<<<<< HEAD

    class Program
    {
        static void Main()
        {
            int[] integers = { 1, 2, 3, 4, 5 };
            SumInterface sumArray = new SumClass();
            //int[] sum = { 0, 0 };
           // sum = 
                sumArray.Sum(integers);
            //Console.Write($"Value array: {sum[0]} and {sum[1]}");
        }
    }

}
=======
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
>>>>>>> 5aa3c217801f5638e0e6f7c910b93b9a48e71395
