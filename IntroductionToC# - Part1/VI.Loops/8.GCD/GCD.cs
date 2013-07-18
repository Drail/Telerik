//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).


using System;

    class GCD
    {
        static void Main()
        {
            Console.Write("Please enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            int b = int.Parse(Console.ReadLine());

            int resultA = a;
            int resultB = b;
            if (b > a)
            {
                int temp = a;
                a = b;
                b = temp;
            }


            while (true)
            {
                int divider = a / b;
                int reminder = a % b;
                if (reminder != 0)
                {
                    a = b;
                    b = reminder;
                }
                else
                {
                    Console.WriteLine("The greatest common divider between {0} and {1} is {2}.", resultA, resultB, divider);
                    break;
                }
            }          
        }
    }

