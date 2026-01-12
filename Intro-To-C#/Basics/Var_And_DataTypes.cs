using System;

namespace Intro_To_CSharp.Basics
{
    internal class Var_And_DataTypes
    {
        public static void DemonstrateVariables()
        {
            Console.WriteLine("Demonstrating Variables and Data Types in C#\n");
            Console.WriteLine("=======[Data Types]=======\n");

            /*
             Data Types in C#:
                - int: Integer numbers (e.g., 1, -5, 42)
                - double: Floating-point numbers (e.g., 3.14, -0.001)
                - char: Single characters (e.g., 'A', 'b', '1')
                - string: Sequence of characters (e.g., "Hello, World!")
                - bool: Boolean values (true or false)
                - decimal: High-precision decimal numbers (e.g., 19.99, -0.01)
                - float: Single-precision floating-point numbers (e.g., 3.14f)
                - long: Large integer numbers (e.g., 9223372036854775807)
                - byte: Small integer numbers (0 to 255)
                - short: Small integer numbers (-32,768 to 32,767)
                - uint, ulong, ushort: Unsigned versions of int, long, and short
                - object: Base type for all data types
             */

            // Integer types
            int age = 25;
            long population = 7800000000L;
            short temperature = -15;
            byte percentage = 100;

            Console.WriteLine("--- Integer Types ---");
            Console.WriteLine($"int age = {age}");
            Console.WriteLine($"long population = {population}");
            Console.WriteLine($"short temperature = {temperature}");
            Console.WriteLine($"byte percentage = {percentage}\n");

            // Floating-point types
            float height = 5.9f;
            double pi = 3.14159265359;
            decimal price = 19.99m;

            Console.WriteLine("--- Floating-Point Types ---");
            Console.WriteLine($"float height = {height}");
            Console.WriteLine($"double pi = {pi}");
            Console.WriteLine($"decimal price = {price:C}\n");

            // Character and String types
            char grade = 'A';
            string name = "John Doe";

            Console.WriteLine("--- Character and String Types ---");
            Console.WriteLine($"char grade = '{grade}'");
            Console.WriteLine($"string name = \"{name}\"\n");

            // Boolean type
            bool isStudent = true;
            bool hasGraduated = false;

            Console.WriteLine("--- Boolean Type ---");
            Console.WriteLine($"bool isStudent = {isStudent}");
            Console.WriteLine($"bool hasGraduated = {hasGraduated}\n");

            // Implicitly typed variables (using var)
            var number = 10; // Compiler infers int
            var message = "Hello, World!"; // Compiler infers string
            var isActive = true; // Compiler infers bool

            Console.WriteLine("--- Implicitly Typed Variables (var) ---");
            Console.WriteLine($"var number = {number} (Type: {number.GetType().Name})");
            Console.WriteLine($"var message = \"{message}\" (Type: {message.GetType().Name})");
            Console.WriteLine($"var isActive = {isActive} (Type: {isActive.GetType().Name})\n");

            // Object type (can hold any type)
            object obj1 = 42;
            object obj2 = "Text";
            object obj3 = true;

            Console.WriteLine("--- Object Type ---");
            Console.WriteLine($"object obj1 = {obj1} (Actual Type: {obj1.GetType().Name})");
            Console.WriteLine($"object obj2 = \"{obj2}\" (Actual Type: {obj2.GetType().Name})");
            Console.WriteLine($"object obj3 = {obj3} (Actual Type: {obj3.GetType().Name})\n");

            // Type ranges demonstration
            Console.WriteLine("--- Type Ranges ---");
            Console.WriteLine($"int range: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long range: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"byte range: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short range: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"float range: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double range: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal range: {decimal.MinValue} to {decimal.MaxValue}");
        }
    }
}