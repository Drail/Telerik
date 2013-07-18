//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

    class MinAndMax
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter numer {0}: ",i+1);
                numberArray[i] = int.Parse(Console.ReadLine());    
            }

            int max = numberArray[0];
            int min = numberArray[0];

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (max < numberArray[i]) 
                {
                    max = numberArray[i];
                }
                if (min > numberArray[i])
                {
                    min = numberArray[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The minimal number is {0}.", min);
            Console.WriteLine("The maximal number is {0}.", max);
        }
    }