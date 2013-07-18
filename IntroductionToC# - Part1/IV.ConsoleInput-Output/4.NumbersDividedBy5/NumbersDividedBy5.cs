/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */


using System;

    class NumberDividedBy5
    {
        static void Main()
        {
            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int temp;
            int counter = 0;
            if (firstNumber > secondNumber)
            {
                temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;
            }
            for (int i = 0; i <= (secondNumber-firstNumber); i++)
            {
                if ((firstNumber + i) % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("The numbers between {0} and {1} that can be divided by 5 with no reminder are {2}", firstNumber, secondNumber, counter);
        }
    }

