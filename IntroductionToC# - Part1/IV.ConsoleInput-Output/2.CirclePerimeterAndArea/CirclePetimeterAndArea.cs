//Write a program that reads the radius r of a circle and prints its perimeter and area.


using System;

    class CirclePetimeterAndArea
    {
        static void Main()
        {
            Console.Write("Please enter the radius (r) of the cirlce: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * r * Math.PI;
            double area = (r * r) * Math.PI;
            Console.WriteLine("The perimeter of the circle is {0}. \nThe area is {1}.", perimeter, area);
        }
    }

