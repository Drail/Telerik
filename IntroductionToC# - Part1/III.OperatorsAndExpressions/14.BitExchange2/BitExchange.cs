//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


using System;

class BinaryExchange2
{
    static void Main()
    {
        Console.WriteLine("The program exchanges a given number of bits (k) starting from point 1 (p) with the bits starting from point 2 (q) of a given integer.");
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of bits you want to exchange: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please enter starting point 1: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Please enter starting point 2: ");
        byte q = byte.Parse(Console.ReadLine());

        int mask = 1;
        int check1;
        int check2;
        int numberCheck;
        byte position1 = p;
        byte position2 = q;
        Console.WriteLine("The binary representation of the original number {0} is: \n{1}.", number, Convert.ToString(number, 2));
        for (byte i = 0; i <= k-1; i++, position1++, position2++)
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
