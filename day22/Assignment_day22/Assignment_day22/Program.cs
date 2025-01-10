
using System;
using System.Drawing;
using RectangleEncapApp.Models;


namespace RectangleEncapApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectang[] rectangle1 = new Rectang[5];
            for (int i = 0; i < 5; i++)
            {
                rectangle1[i] = new Rectang();
                Console.WriteLine($"Please enter set {i + 1}");
                rectangle1[i].width = Int32.Parse(Console.ReadLine());
                rectangle1[i].height = Int32.Parse(Console.ReadLine());
                rectangle1[i].color = Console.ReadLine();
            }
        
            PrintInfo(rectangle1);

            public void PrintInfo(Rectang[] rectan)
            {
                int[] area= new int[5];
                for (int i = 0; i < 5; i++)
                { 
                    area[i]=rectan[i].CalculateArea(rectan[i].width, rectan[i].height, rectan[i].color);
                    Console.WriteLine($"Area & Color of set {i+1}: {rectan[i].CalculateArea(rectan[i].width, rectan[i].height, rectan[i].color)} {rectan[i].color}");
                }
            }
            
        }
    }
}
