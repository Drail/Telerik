/* Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0 */


using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Please enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("The equation is linear.");
            }
            else
            {
                double discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("There are two roots: {0} and {1}.", x1, x2);
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has one root: {0}.", x);
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("The equation has no solution.");
                }
            }
        }
    }
