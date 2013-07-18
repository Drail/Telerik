//Write a program that finds the biggest of three integers using nested if statements.


using System;

    class BiggestInteger
    {
        static void Main()
        {
            Console.Write("Please enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third integer: ");
            int c = int.Parse(Console.ReadLine());

            if (a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is the biggest.");
                }
                else
                {
                    Console.WriteLine("C is the biggest.");
                }
            }
            if (b>a)
            {
                if (b > c)
                {
                    Console.WriteLine("B is the biggest.");
                }
                else
                {
                    Console.WriteLine("C is the biggest.");
                }
            }
        }
    }
