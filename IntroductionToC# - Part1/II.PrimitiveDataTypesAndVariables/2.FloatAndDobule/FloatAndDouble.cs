﻿/*Which of the following values can be assigned to a variable of type float and which to a variable 
 * of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? */


using System;

class FloatAndDouble
{
    static void Main()
    {
        double a = 34.567839023d;
        float b = 12.345f;
        double c = 8923.1234857d;
        float d = 3456.091f;

        Console.WriteLine("The types of the values are as follows: \n double={0} \n float={1} \n double={2} \n float={3}", a, b, c, d);
    }
}
