//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

    class FactorialsDivided
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger resultK = 1;
            BigInteger resultN = 1;

            if (k < n)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    resultK = resultK * i;
                }

                for (int i = 0; i < (k - (k - n)); i++)
                {
                    resultN = resultN * (k - i);
                }

                BigInteger finalResult = resultK * resultN;

                Console.WriteLine("K!*N!/(K-N)! = {0}", finalResult);
            }
        }
    }