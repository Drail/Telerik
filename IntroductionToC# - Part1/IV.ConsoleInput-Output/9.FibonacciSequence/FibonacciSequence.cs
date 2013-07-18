using System;

    class FibonacciSquence
    {
        static void Main()
        {
            decimal a = 0;
            decimal b = 1;
            int counter = 0;
            for (int i = 0; i <= 100; i++, counter++)
            {
                Console.WriteLine("{0} : {1}", counter,a);
                decimal sum = a + b;
                a = b;
                b = sum;
            }

        }
    }

