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
        BigInteger result = 1;

        if (k > n)
        {
            Console.WriteLine("Out of range!");
        }
        else
        {
            int start = k + 1;
            for (int i = start; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("K!/N! = {0}", result);
        }
    }
}
