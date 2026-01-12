using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Intro_To_CSharp.Basics.OOP
{
    internal class Arrays
    {
        public static void DemonstrateArray()
        {
            // Declare and initialize an array
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            // Access and print array elements
            Console.WriteLine("Array Elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {numbers[i]}");
            }
            // Modify an array element
            numbers[2] = 99;
            Console.WriteLine("\nAfter modifying the element at index 2:");
            Console.WriteLine($"Element at index 2: {numbers[2]}");
            // Print the length of the array
            Console.WriteLine($"\nLength of the array: {numbers.Length}");
        }
    }
}
