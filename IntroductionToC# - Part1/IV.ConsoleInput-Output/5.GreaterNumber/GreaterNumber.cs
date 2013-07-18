//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

    class GreaterNumber
    {
        static void Main()
        {
            Console.Write("Please enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is {0}.", Math.Max(a,b));
        }
    }
