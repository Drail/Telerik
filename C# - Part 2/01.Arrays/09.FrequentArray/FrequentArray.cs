//Write a program that finds the most frequent number in an array.

using System;

    class FrequentArray
    {
        static void Main()
        {
            Console.Write("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int frequencyTemp = 1;
            int frequencyMax = 1;
            int tempStart = 0;
            int maxStart = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int m = 1; m < array.Length; m++)
            {
                if (array[m] == array[m-1])
                {
                    tempStart = m-frequencyTemp;
                    frequencyTemp++;
                }
                else
                {
                    if (frequencyTemp>frequencyMax)
                    {
                        frequencyMax = frequencyTemp;
                        maxStart = tempStart;
                    }
                    frequencyTemp = 1;
                    tempStart = 0;
                }
            }

            Console.WriteLine("The most frequent number in the array is {0}. Appearing {1} times.",array[maxStart], frequencyMax);

        }
    }