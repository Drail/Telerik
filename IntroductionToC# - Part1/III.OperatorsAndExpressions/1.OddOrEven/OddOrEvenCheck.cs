//Write an expression that checks if given integer is odd or even.


using System;

    class OddOrEvenCheck
    {
        static void Main()
        {
            Console.WriteLine("This is a program that checks if given number is odd or even");
            Console.Write("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) //Checks if the can be divided by 2 with no reminder
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

        }
    }

