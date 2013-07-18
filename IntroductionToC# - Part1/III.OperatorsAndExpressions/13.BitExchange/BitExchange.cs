//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BinaryExchange
{
    static void Main()
    {
        Console.WriteLine("The program exchanges the 3rd, 4th and 5th bit with the 24th, 25th and 26th bit of a given 32-bit unsigned integer.");
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        int check1;
        int check2;
        int numberCheck;
        byte position1 = 3;
        byte position2 = 24;
        Console.WriteLine("The binary representation of the original number {0} is: \n{1}.", number, Convert.ToString(number, 2));
        for (byte i = 1; i <= 3; i++, position1++, position2++)
        {
            mask = mask << position1;
            check1 = (mask & number) >> position1;
            mask = mask >> position1;
            mask = mask << position2;
            check2 = (mask & number) >> position2;
            mask = mask >> position2;
            if (check1 != check2)
            {
                if (check1 == 1)
                {
                    numberCheck = number | (mask << position2);
                    number = numberCheck ^ (mask << position1);
                }
                else
                {
                    numberCheck = number ^ (mask << position2);
                    number = numberCheck | (mask << position1);
                }

            }
        }
        Console.WriteLine("The binary representation of the new number {0} is: \n{1}.", number, Convert.ToString(number, 2));
    }
}

 