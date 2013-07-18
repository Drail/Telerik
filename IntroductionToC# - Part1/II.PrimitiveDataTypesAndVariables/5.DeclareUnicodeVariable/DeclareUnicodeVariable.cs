//Declare a character variable and assign it with the symbol that has Unicode code 72. 

using System;

    class DeclareUnicodeVariable
    {
        static void Main()
        {
            char symbolUnicode = '\u0048'; //The hexadecimal value of 72 is 48. uXXXX is the correct format of entering unicode symbols.
            Console.WriteLine("The Unicode expression of 72 (hex 48) is {0}", symbolUnicode);
        }
    }
