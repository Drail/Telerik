//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


using System;

    class PointCircle
    {
        static void Main()
        {
            Console.WriteLine("The program checks if given point (by coordinates x and y) is within the circle K (radius 5).");
            Console.Write("Please enter the value of x:");
            string strX = Console.ReadLine();
            Console.Write("Please enter the value of y:");
            string strY = Console.ReadLine();
            double x = double.Parse(strX);
            double y = double.Parse(strY);
            double circleRadius = 5.0d;
            bool check = (x * x) + (y * y)  >= (circleRadius * circleRadius);

            if (check)
            {
                Console.WriteLine("The given point is not within the circle K.");
            }
            else
            {
                Console.WriteLine("The given point is within the circle K.");
            }
        }
    }

