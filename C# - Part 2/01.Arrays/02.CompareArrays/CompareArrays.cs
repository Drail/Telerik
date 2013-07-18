//Write a program that reads two arrays from the console and compares them element by element.


using System;

    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Please enter the leght of the arrays: ");
            int arrL = int.Parse(Console.ReadLine());
            int[] array1 = new int[arrL];
            int[] array2 = new int[arrL];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Please enter the {0} int for the first array: ",i+1);
                array1[i] = int.Parse(Console.ReadLine());
                Console.Write("Please enter the {0} int for the second array: ",i+1);
                array2[i] = int.Parse(Console.ReadLine());

                if (array1[i] == array2[i])
                {
                    Console.WriteLine("Integers number {0} in the arrays are equal", i+1); 
                }
                else
                {
                    Console.WriteLine("Integers number {0} in the arrays are not equal", i+1);
                }
            }
        }
    }
