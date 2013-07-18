// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.


using System;

    class DivideByFiveAndSeven
    {
        static void Main()
        {
            Console.WriteLine("The program checks if given number can be divided by 5 and 7 at the same time (with no remainder).");
            Console.Write("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool divideFive = number % 5 == 0;
            bool divideSeven = number % 7 == 0;
            if (divideFive && divideSeven)
            {
                Console.WriteLine("The number given can be divided by both five and seven with no remainder.");
            }
            else
            {
                Console.WriteLine("The number given can not be divided by both five and seven with no remainder." );
            }
        }
    }

