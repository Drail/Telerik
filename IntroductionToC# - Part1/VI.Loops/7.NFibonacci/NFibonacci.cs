//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


using System;
using System.Numerics;

    class NFibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of Fibonacci numbers you want to display: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger a = 0;
            BigInteger b = 1;
            int counter = 1;
            for (int i = 0; i < n; i++, counter++)
            {
                Console.WriteLine("{0} : {1}", counter, a);
                BigInteger sum = a + b;
                a = b;
                b = sum;
            }
        }
    }


