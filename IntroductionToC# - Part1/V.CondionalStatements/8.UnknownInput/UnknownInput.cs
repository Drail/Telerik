/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement. */


using System;

    class UnknownInput
    {
        static void Main()
        {
            Console.Write("Please input string or number (string, double or int): ");
            string input = Console.ReadLine();

            double number;

            bool isNumber = double.TryParse(input, out number);

            if (isNumber)
            {
                number = number + 1;
                Console.WriteLine("The new value of the number is: {0}.", number);
            }
            else
            {
                input = input + "*";
                Console.WriteLine("The new value of the string is: {0}.", input);
            }
        }
    }
