//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

    class CalculateSum
    {
        static void Main()
        {
            Console.WriteLine("The program calculates (with accuracy of 0.001) the sum of 1+1/2-1/3+1/4....1/N");
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;

            for(double i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (1 / i);
                }
                else
                {
                    sum = sum - (1 / i);
                }
               
            }
            Console.WriteLine("The total sum is {0:0.000}", sum);
        }
    }

