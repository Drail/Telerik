/*Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
 * If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
 *  Use a switch statement and at the end print the calculated new value in the console. */


using System;

    class BonusScore
    {
        static void Main()
        {
            Console.Write("Please enter a number beteween 1 and 9: ");
            int number = int.Parse(Console.ReadLine());
            int result;
            switch (number)
            {   
                case 1:
                case 2:
                case 3:
                    result = number * 10;
                    Console.WriteLine("{0} is multiplied by 10: {1}", number, result);
                    break;
                case 4:
                case 5:
                case 6:
                    result = number * 100;
                    Console.WriteLine("{0} is multiplied by 100: {1}", number, result);
                    break;
                case 7:
                case 8:
                case 9:
                    result = number * 1000;
                    Console.WriteLine("{0} is multiplied by 1000: {1}", number, result);
                    break;
                default:
                    Console.WriteLine("Out of range!");
                    break;
            }
        }
    }

