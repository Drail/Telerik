//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.


using System;

    class TwoIntegers
    {
        static void Main()
        {
            Console.Write("Please enter the first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            int b = int.Parse(Console.ReadLine());
            int check;

            if (a > b)
            {
                check = a;
                a = b;
                b = check;
                Console.WriteLine("The initial values were {0} and {1}, after the switch of values they are {2} and {3}.", b, a, a, b);
            }

            else
            {
                Console.WriteLine("{0} is greater than {1}.", b,a);
            }
        }
    }
