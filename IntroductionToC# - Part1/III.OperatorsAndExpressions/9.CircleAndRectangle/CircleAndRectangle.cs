/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
and out of the rectangle R(top=1, left=-1, width=6, height=2). */


using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("The program checks if given point (by coordinates x and y) is within the circle K (radius 3) and out of rectangle R (top left point (-1,1), widht=6, height = 2).");
        Console.Write("Please enter the value of x:");
        string strX = Console.ReadLine();
        Console.Write("Please enter the value of y:");
        string strY = Console.ReadLine();
        double x = double.Parse(strX);
        double y = double.Parse(strY);
        double circleCenter = 1d;
        double circleRadius = 3d;
        bool checkCircle = ((x- circleCenter) * (x - circleCenter)) + ((y - circleCenter )* (y - circleCenter)) < (circleRadius * circleRadius);
        bool checkRectangle = ( (x<= -1) || (x >= 5))&& ((y <= -1) || (y >= 1));
        if (checkCircle)
        {
            if (checkRectangle)
            {
            Console.WriteLine("The given point is within the circle K and out of rectangle R.");
            }
            else
            {
                Console.WriteLine("The given point is within the circle K and in rectangle R.");
            }
        }
        else
        {
            if (checkRectangle)
            {
                Console.WriteLine("The given point is outside of circle K and rectangle R.");
            }
            else
            {
                Console.WriteLine("The given point is outside of circle K and  inside of rectangle R.");
            }
        }
    }
}


