//Write a program that reads 3 integer numbers from the console and prints their sum.


using System;

    class ThreeIntegers
    {
        static void Main()
        {
            Console.Write("Please enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third integer: ");
            int c = int.Parse(Console.ReadLine());
            int sum = a+b+c;
            Console.WriteLine("The sum of the integers is: {0}", sum);
        }
    }

