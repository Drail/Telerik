//Write a program that finds the sequence of maximal sum in given array. 

using System;

    class MaxSequenceSum
    {
        static void Main()
        {
            Console.Write("Please enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sumMax = array[0];
            int sumTemp = array[0];
            int sequenceMax = 1;
            int sequenceTemp = 1;
            int indexMax = 0;
            int indexTemp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            } 

            for (int m = 1; m < array.Length; m++)
            {
                if (array[m] + sumTemp > array[m])
                {
                    sumTemp = sumTemp + array[m];
                    sequenceTemp++;
                }

                else
                {
                    sumTemp = array[m];
                    indexTemp = m;
                    sequenceTemp = 1;
                }
                if (sumTemp > sumMax)
                {
                    sumMax = sumTemp;
                    indexMax = indexTemp;
                    sequenceMax = sequenceTemp;
                }
            }
            Console.WriteLine();

            for (int l = indexMax; l < indexMax+sequenceMax; l++)
            {
                Console.Write("{0}, ",array[l]);
            }
            Console.WriteLine("\nMax sequence is: {0}", sumMax);
        }
    }
