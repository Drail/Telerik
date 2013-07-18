/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the 
 * entire ASCII table of characters on the console. */


using System;

    class ASCIITable
    {
        static void Main()
        {
            Console.WriteLine("The full ASCII Table:");
            {
                for (int table = 0; table < 127; table++)
                {
                    Console.WriteLine("Character: {0} = {1}", table, (char)table);
                }
            }
        }
    }
