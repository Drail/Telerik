//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

    class PrimeNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program checks if given number is a primer number (range 1-100).");
            Console.Write("Please enter a number (1-100):");
            string inputNumber = Console.ReadLine();
            int n = int.Parse(inputNumber);
            //for (int n=2; n<=100; n++) Remove the comment from this line to create a cicle that checks the app.
             if ((n >= 1 && n<=100))
             {
                 if ( (n == 2 || n == 3 || n == 5 || n == 7) || (n%2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0))
                 {
                     Console.WriteLine("The number {0} is a prime number.", n);
                 } 
                 else
                 {
                     Console.WriteLine("The number {0} is not a prime number.", n);
                 }
             }
             else
             {
                 Console.WriteLine("The number is out of range.");
             }
        }
    }

