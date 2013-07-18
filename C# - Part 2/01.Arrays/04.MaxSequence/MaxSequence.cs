//Write a program that finds the maximal sequence of equal elements in an array.


using System;

    class MaxSequence
    {
        static void Main()
        {
            Console.Write("Please enter the lenght of the array: ");
            int arrL = int.Parse(Console.ReadLine());
            int[] array = new int[arrL];
            int start = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int m = 1; m < array.Length; m++)
            {
                if (array[m] == array[m-1])
                {
                    start = m-lenght;
                    lenght++;
                }
                else
                {
                    if (lenght>bestLenght)
                    {
                        bestLenght = lenght;
                        bestStart = start;
                    }
                    lenght = 1;
                    start = 0;
                }
            }
            Console.Write("The maximal sequance in the array starts from position {0} and is {1} integers long. --> ", bestStart, bestLenght);
            for (int k = bestStart; k < bestStart+bestLenght; k++)
            {
                Console.Write(array[k] + " ");
            }

        }
    }

