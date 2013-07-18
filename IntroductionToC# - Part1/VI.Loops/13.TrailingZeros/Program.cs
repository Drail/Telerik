//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 

using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            int zeros = n / 5;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            Console.WriteLine("N = {0} --> N! = {1} --> {2}",n,factorialN,zeros);
        }
    }
