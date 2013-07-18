/*Declare two string variables and assign them with following value:
 "The "use" of quotations causes difficulties."
Do the above in two different ways: with and without using quoted strings. */

using System;

    class Quotations
    {
        static void Main()
        {
            string quotations1 =@"The ""use"" of quotations causes difficulties.";
            string quotations2 ="The \"use\" of quotations causes difficulties";

                Console.WriteLine("Using the @ sign in front of the string we get:");
                Console.WriteLine(quotations1);
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("Using \\ in front of the quotations we get:");
                Console.WriteLine(quotations2);
        }
    }
