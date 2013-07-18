using System;

    class QuickSort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0, m = 1; i < array.Length; i++)
            {
                Console.Write("Please enter string {0}: ",m);
                array[i] = Console.ReadLine();
            }
            Quicksort(array, 0, array.Length - 1);

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }