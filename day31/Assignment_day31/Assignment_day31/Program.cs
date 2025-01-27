using System;
namespace Assignment_day31
{
    public interface SumInterface
    {
        void Sum(int[] array);
    }

    public abstract class SumAbstract : SumInterface
    {
        public abstract void Sum(int[] array);
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