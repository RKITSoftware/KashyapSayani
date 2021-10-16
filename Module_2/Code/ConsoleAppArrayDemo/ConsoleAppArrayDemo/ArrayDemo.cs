using System;
using System.Linq;
 
namespace ConsoleAppArrayDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            // Create an Array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // Access an element of array
            Console.WriteLine("Fourth Element Of Array Is : "+cars[3]);

            // Loop Through an Array
            Console.WriteLine("Loop Through an Array");
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort Arrays
            Array.Sort(cars);
            Console.WriteLine("\nSorted Array : ");

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Array Length
            Console.WriteLine("\nLength Of Array : " + cars.Length);

            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine("\nMax : "+myNumbers.Max());  // returns the largest value
            Console.WriteLine("Min : "+myNumbers.Min());  // returns the smallest value
            Console.WriteLine("Sum : "+myNumbers.Sum());  // returns the sum of elements

            // Create an array of four elements, and add values later
            string[,] cars1 = new string[2,2];

            // Create an array of four elements and add values right away 
            string[,] cars2 = new string[2,2] { { "Volvo", "BMW" } , { "Ford", "Mazda" } };

            // Create an array of four elements without specifying the size
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[,] cars4 = { { "Volvo", "BMW" }, { "Ford", "Mazda" } };
        }
    }
}