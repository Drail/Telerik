/*Create a program that assigns null values to an integer and to double variables. 
 * Try to print them on the console, try to add some values or the null literal to them and see the result. */


using System;
    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("A = {0} \nB = {1}\nBoth variables equal null.", a,b);
            int? c = a + 75;
            double? d = b + 34.0003;
            Console.WriteLine("A + 75 = {0} \nB + 34.003 = {1}", c, d);
            Console.WriteLine("If we try to add values to null values we get null.");

        }
    }

