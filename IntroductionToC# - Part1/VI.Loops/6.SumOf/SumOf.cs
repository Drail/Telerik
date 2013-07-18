//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;
using System.Numerics;

    class SumOf
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter X: ");
            int x = int.Parse(Console.ReadLine());
            decimal factorialN = 1;
            decimal totalSum = 1;
            decimal divider = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
                divider = divider * x;
                totalSum = totalSum + (factorialN/divider); 
            }
            Console.WriteLine("Sum S = {0}",totalSum);
        }
    }
