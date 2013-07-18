//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:


using System;

    class NumberMatrix
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 20)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int k = i; k <= (i + n - 1); k++)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
