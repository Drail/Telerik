using System;

namespace _8.TrapeziodArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("The program calculates the area of trapezoid by given sides and height.");
            Console.Write("Please enter side a: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Please enter side b: ");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Please enter the height h: ");
            float heightH = float.Parse(Console.ReadLine());

            float trapezoidArea = ((sideA + sideB) / 2) * heightH;

            Console.WriteLine("The trapezoid are is {0}.", trapezoidArea);
        }
    }
}
