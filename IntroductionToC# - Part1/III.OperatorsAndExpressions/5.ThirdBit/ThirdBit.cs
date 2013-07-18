// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


using System;

class bit3
{
    static void Main()
    {
        Console.WriteLine("The program checks if the third bit of given number is 1");
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
       
        int mask = 1<< 3;
        int addMask = number & mask;

        if (addMask != 0)
        {
            Console.WriteLine("The bit in position 3 is 1");
        }
        else
        {
            Console.WriteLine("The bit in position 3 is 0");
        }
        // This part of the code show the numbers behind the bitwise operation.
        string numberBinary = Convert.ToString(number, 2);
        string maskBinary = Convert.ToString(mask, 2);
        string addMaskBinary = Convert.ToString(addMask, 2);

        Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);

    }
}
