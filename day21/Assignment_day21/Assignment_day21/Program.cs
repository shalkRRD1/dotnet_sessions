
using System;
using System.Drawing;
using CircleAbstractionApp.Models;

class CircleTest
{
    static void Main()
    {

        Circle circle1;//small expects a rectangel object
        circle1 = new Circle();
        circle1.radius = 5;
        Console.WriteLine($"small radius is {circle1.radius}, area is {circle1.CalculateArea()}");

        Circle circlel2 = new Circle();
        circlel2.radius = 50;
        Console.WriteLine($"big radius is {circlel2.radius}, area is {circlel2.CalculateArea()}");

    }

}