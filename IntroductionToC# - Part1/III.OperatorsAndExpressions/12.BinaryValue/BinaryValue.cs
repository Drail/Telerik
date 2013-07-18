/* We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of 
operators that modifies n to hold the value v at the position p from the binary representation of n. */

using System;

class BinaryValue
{
    static void Main()
    {
        Console.WriteLine("The program checks if given bit of given number is 1 or 0.");
        Console.Write("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int addMask = number & mask;

        if (value == 0)
        {
            if (addMask != 0)
            {
                int newNumber = number & (~(1 << position));
                Console.WriteLine("The original value was {0}, after the change with {1} of bit {2}, the new value is {3}.", Convert.ToString(number,2), value, position, Convert.ToString(newNumber,2));
            }
            else
            {
                int newNumber = number;
                Console.WriteLine("The original value was {0}, after the change with {1} of bit {2}, the new value is {3}.", Convert.ToString(number, 2), value, position, Convert.ToString(newNumber, 2));
            }
        }
        else
        {
            if (addMask != 0)
            {
                int newNumber = number;
                Console.WriteLine("The original value was {0}, after the change with {1} of bit {2}, the new value is {3}.", Convert.ToString(number, 2), value, position, Convert.ToString(newNumber, 2));
            }
            else
            {
                int newNumber = number | (1 << position);
                Console.WriteLine("The original value was {0}, after the change with {1} of bit {2}, the new value is {3}.", Convert.ToString(number, 2), value, position, Convert.ToString(newNumber, 2));
            }
        }
    }
}
