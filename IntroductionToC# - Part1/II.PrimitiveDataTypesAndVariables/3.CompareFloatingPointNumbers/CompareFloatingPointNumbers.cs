/*Write a program that safely compares floating-point numbers with precision of 0.000001. 
 * Examples:(5.3 ; 6.01) - false;  (5.00000001 ; 5.00000003) - true */


using System;

    class CompareFloatingPointNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program is comparing floating-point numbers with precision of 0.000001.");
            Console.Write("Please enter the first number:");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The two numbers are {0} and {1}", firstNumber, secondNumber);
            bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
            if (comparing == true)
            {
                Console.WriteLine("The two number are equal with with precision of 0.000001.");
            }
            else
            {
                Console.WriteLine("The two number are not equal with with precision of 0.000001.");
            }
        }
    }
