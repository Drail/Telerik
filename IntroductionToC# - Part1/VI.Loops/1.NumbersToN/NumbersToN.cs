//Write a program that prints all the numbers from 1 to N.


using System;

    class NumbersToN
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }

