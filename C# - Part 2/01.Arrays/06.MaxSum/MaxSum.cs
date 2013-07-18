//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


using System;

    class MaxSum
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] arrayN = new int[N];
            int maxSum = 0;
            
            for (int i = 0; i < N; i++)
            {
                Console.Write("Please enter integer {0}: ",i);
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayN);
            Array.Reverse(arrayN);

            for (int m = 0; m < K; m++) 
            {
                maxSum += arrayN[m];
            }
            Console.WriteLine("The maximal sum of integers is {0}", maxSum); 
        }
    }
