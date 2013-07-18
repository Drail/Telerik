//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.


using System;

    class Divisible3And7
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0) //Check if the numbers are divisible by 3 and 7.
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

