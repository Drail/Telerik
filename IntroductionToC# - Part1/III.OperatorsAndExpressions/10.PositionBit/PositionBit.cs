/*Write a boolean expression that returns if the bit at position p (counting from 0) in a 
 * given integer number v has value of 1. Example: v=5; p=1  false. */


using System;

class PositionBit
{
    static void Main()
    {
        Console.WriteLine("The program checks if given bit of given number is 1");
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int addMask = number & mask;
        int bit = addMask >> position;
        bool check = bit == 1;

        if(check)
        {
            Console.WriteLine("The bit in position {0} is 1", position);
        }
        else
        {
            Console.WriteLine("The bit in position {0} is 0", position);
        }
        // This part of the code show the numbers behind the bitwise operation.
        string numberBinary = Convert.ToString(number, 2);
        string maskBinary = Convert.ToString(mask, 2);
        string addMaskBinary = Convert.ToString(addMask, 2);

        Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);

    }
}
