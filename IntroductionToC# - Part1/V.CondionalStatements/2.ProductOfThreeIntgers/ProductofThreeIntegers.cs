//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.


using System;

    class ProductOfThreeIntegers
    {
        static void Main()
        {
            int lenght = 3;
            int[] intArray = new int[lenght];
            Console.Write("Please enter the first integer: ");
            intArray[0] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second integer: ");
            intArray[1] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third integer: ");
            intArray[2] = int.Parse(Console.ReadLine());

            int count = 0;
            bool zero = false;
            foreach (var number in intArray)
            {
                if (number < 0)
                {
                    count++;
                }
                if (number == 0)
                {
                    zero = true;
                }
            }

            if (zero)
            {
                Console.WriteLine("The product of the three integers is ZERO!");
            }
            else
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine("The product of the three integers is positive!");
                }
                else
                {
                    Console.WriteLine("The product of  the three integers is negative!");
                }
            }        
        }
    }

