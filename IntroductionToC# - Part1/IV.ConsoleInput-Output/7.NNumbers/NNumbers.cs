﻿//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 


using System;

    class NNumbers
    {
        static void Main()
        {
            Console.Write("Please enter how many numbers you wish to calculate: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum=0;
            for (int i = 0; i < n; i++, counter++)
            {
                Console.Write("Please number {0}: ",counter);
                int a = int.Parse(Console.ReadLine());
                sum = sum + a;

            }
            Console.WriteLine("The sum of the numbers is {0}.", sum);
        }
    }

