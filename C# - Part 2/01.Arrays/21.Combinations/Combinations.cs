using System;

    class Combinations
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number K: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Repeat(1, k).ToArray();
            int index;

            do
            {
                index = 1;
                if (IncreasingOrder(array))
                {
                    Print(array);
                }
                for (int i = 0; i < k; i++)
                {
                    array[i] += index;
                    if (array[i] <= n)
                    {
                        index = 0;
                        break;
                    }
                    else
                    {
                        array[i] = index = 1;
                    }
                }
            } while (index != 1);
        }
        static bool IncreasingOrder(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] <= arr[j])
                        return false;

            return true;
        }
        static void Print(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }