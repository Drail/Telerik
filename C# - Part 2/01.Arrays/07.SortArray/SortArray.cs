//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;

    class SortArray
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the lenght of the array: ");
            int arrL = int.Parse(Console.ReadLine());
            int[] array = new int[arrL];
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Selection Sort implemetation
            int tmp, minKey;

            for (int j = 0; j < arrL - 1; j++)
            {
                minKey = j;

                for (int k = j + 1; k < arrL; k++)
                {
                    if (array[k] < array[minKey])
                    {
                        minKey = k;
                    }
                }

                tmp = array[minKey];
                array[minKey] = array[j];
                array[j] = tmp;
            }

            Console.WriteLine("The array after Selection Sort is: ");
            for (int i = 0; i < arrL; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
        }
    }
