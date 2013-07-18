//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.


using System;

    class IntervalOfNumbers
    {
        static void Main()
        {
            Console.Write("Please enter the last number of the interval you wish to print: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

