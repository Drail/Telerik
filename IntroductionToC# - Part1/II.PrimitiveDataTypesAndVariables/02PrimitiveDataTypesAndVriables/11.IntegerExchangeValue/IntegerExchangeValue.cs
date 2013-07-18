using System;

    class IntegerExchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Original Value:\na = 5\nb = 10\n\nNew Value:\na = {0}\nb = {1}", a, b);
        }
    }
