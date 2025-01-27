<<<<<<< HEAD
﻿using System;

namespace Assignment_day30
=======
using System;

namespace ProductApp
>>>>>>> f4524d2e0a15df7adfa71ac312a8f89bab067c10
{
    public abstract class Product
    {
        public abstract int HighestProduct(int[] integer);
    }
    public class AdjacentProduct : ProductCalculator
    {
        public override int HighestProduct(int[] integer)
        {
            int highestProduct = int.MinValue;

            for (int i = 0; i < integer.Length - 1; i++)
            {
                int product = integer[i] * integer[i + 1];
                if (product > highestProduct)
                {
                    highestProduct = product;
                }
            }
            return highestProduct;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] integer = { 1, 3, 5, 2, 6, 2, 9 };
            ProductCalculator calculator = new AdjacentProduct();
            int highestProduct = calculator.HighestProduct(integer);
            Console.WriteLine("The highest adjacent product is: " + highestProduct);
        }
    }
}
