//Sort 3 real values in descending order using nested if statements.


using System;

    class SortIntegers
    {
        static void Main()
        {
            Console.Write("Please enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third integer: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    if (c>b)
                    {
                        Console.WriteLine("A({0})>C({1})>B({2})",a,c,b);
                    }
                    else
                    {
                        Console.WriteLine("A({0})>B({1})>C({2})", a, b, c);
                    }
                }
                else
                {
                    Console.WriteLine("C({0})>A({1})>B({2})",c,a,b);
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    if (a>c)
                    {
                        Console.WriteLine("B({0})>A({1})>C({2})", b, a, c); 
                    }
                    else
                    {
                        Console.WriteLine("B({0})>C({1})>A({2})", b, c, a);
                    }
                }
                else
                {
                    Console.WriteLine("C({0})>B({1})>A({2})",c,b,a);
                }
            }
        }
    }

