using System;

public interface RotateInterface
{
    int[] Rotate(int[] array);
}

public abstract class RotateAbstract : RotateInterface
{
    public abstract int[] Rotate(int[] array);
}

public class RotateClass : RotateAbstract
{
    public override int[] Rotate(int[] array)
    {
        //int[] arr = new int[10];
        Console.WriteLine("Enter number of rotations: ");
        int temp = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter direction of rotations:Press C for Clockwise and A for anti-clockwise");
        //string str = Console.ReadLine();
        char direction = Char.ToUpper(Console.ReadKey().KeyChar);
        int rotateTemp = 0;

        while (temp != 0)
        {
            switch (direction)
            {
                case 'A':
                    rotateTemp = array[0];
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        Console.WriteLine($"Value: {i}");
                        array[i] = array[i + 1];
                    }
                    array[array.Length - 1] = rotateTemp;
                    break;
                case 'C':
                    rotateTemp = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        Console.WriteLine($"Value: {i}");
                        array[i - 1] = array[i];
                    }
                    array[array.Length - 1] = rotateTemp;
                    break;
                default:
                    Console.WriteLine("Either A or C acceptable");
                    break;
            }
            temp--;
        }
        return array;
    }
}

class Program
{
    static void Main()
    {
        int[] integers = { 1, 2, 3, 4, 5, 6, 7 };
        RotateInterface rotateArray = new RotateClass();
        int[] rotated = rotateArray.Rotate(integers);
        Console.WriteLine("Rotated array is :");
        for (int i = 0; i < rotated.Length; i++)
        {
            Console.Write($"{rotated[i]} ");
        }
    }
}