//Write a program that finds the greatest of given 5 variables.


using System;

    class GreatestOfFive
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first variable: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second variable: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third variable: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Please enter the forth variable: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth variable: ");
            double e = double.Parse(Console.ReadLine());

            if (a>b && a>e && a>c && a>d)
            {
                Console.WriteLine("A is the greates out of five.");
            }
            else if (b>a && b>c && b>d && b>e)
            {
                Console.WriteLine("B is the greates out of five.");
            }
            else if (c > b && c > a && c > d && c > e)
            {
                Console.WriteLine("C is the greates out of five.");
            }
            else if (d > b && d > a && d > c && d > e)
            {
                Console.WriteLine("D is the greates out of five.");
            }
            else if (e > b && e > a && e > d && e > c)
            {
                Console.WriteLine("E is the greates out of five.");
            }
        }
    }

