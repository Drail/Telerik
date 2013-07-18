//Write a program to calculate the Nth Catalan number by given N.
// THE NINTH AND THE TENTH EXERCISES ARE THE SAME!


using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger catalanN;
            BigInteger doubleN = n * 2;
            BigInteger factorialNPlusOne = 1;
            BigInteger factorialdoubleN = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }

            for (int k = 1; k <= n+1; k++)
			{
			  factorialNPlusOne = factorialNPlusOne * k;
			}

            for (int l = 1; l <= doubleN; l++)
			{
                factorialdoubleN = factorialdoubleN * l;
			}
            catalanN = factorialdoubleN / (factorialNPlusOne * factorialN);
            Console.WriteLine("The {0}th Catalan number is: {1}.",n,catalanN);
        }
    }
