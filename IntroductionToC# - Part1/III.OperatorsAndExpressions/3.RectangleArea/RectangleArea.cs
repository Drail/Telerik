//Write an expression that calculates rectangle’s area by given width and height.


using System;

    class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the rectangle's area by given Height and Width.");
            Console.Write("Please enter the rectangle's height:");
            int rectangleHeight = int.Parse(Console.ReadLine());
            Console.Write("Please enter the rectangle's Width:");
            int rectangleWidth = int.Parse(Console.ReadLine());
            int rectangleArea = rectangleWidth * rectangleHeight;
            Console.WriteLine("The rectangle's area is: {0}", rectangleArea);
        }
    }
