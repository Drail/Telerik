//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


using System;

    class BinarySort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            

            Console.Write("Enter the number you are searching for: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            //The binary search

            int low = 0;
            int high = (int)array.Length - 1;
            int midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (searchedNumber == array[midpoint])
                {
                    found = true;
                    Console.WriteLine("The index of the number {0} in the sorted array,\nstarting from zero is {1}.", searchedNumber, midpoint);
                    break;
                }
                else if (searchedNumber < array[midpoint])
                    high = midpoint - 1;
                else
                    low = midpoint + 1;
            }

            if (found == false)
            {
                Console.WriteLine("The number you are searching for does not exist in the array.");
            }
        }
    }
