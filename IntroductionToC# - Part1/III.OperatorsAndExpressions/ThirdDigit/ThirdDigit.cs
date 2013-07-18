//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("The program checks if the third digit in a given number is 7.");
            Console.Write("Please enter a number:");
            int numberInput = int.Parse(Console.ReadLine());
            int thirdDigit = (numberInput / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("The thrid digit is seven.");
            }
            else
            {
                Console.WriteLine("The third digit is not seven.");
            }
        }
    }
