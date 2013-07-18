/*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
 * short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. */


using System;

    class DeclareFiveVariables
    {
        static void Main()
        {
            ushort a = 52130;
            sbyte b = -115;
            uint c = 4825932;
            byte d = 97;
            short e = -10000;
            Console.WriteLine("The types of the values are as follows: \n ushort={0} \n sbyte={1} \n uint={2} \n byte={3} \n short={4}", a,b,c,d,e);
        }
    }

