//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.


using System;

    class ZeroSubset
    {
        static void Main()
        {
            int subsetCount = 5;
            int zeroCount = 0;
            int[] intArray = new int[subsetCount];
            Console.Write("Please enter the first number: ");
            intArray[0] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            intArray[1] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            intArray[2] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the forth number: ");
            intArray[3] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth number: ");
            intArray[4] = int.Parse(Console.ReadLine());

            for (int i = 0; i < subsetCount; i++)
            {
                for (int j = i+1; j < subsetCount; j++)
			    {
			        if (intArray[i] + intArray[j] == 0)
                        {
                            zeroCount++;
                        }
                    for (int k = j+1; k < subsetCount; k++)
                    {
                        if (intArray[i]+intArray[j]+intArray[k] ==0)
                            {
                                zeroCount++;
                            }
                        for (int l = k+1; l < subsetCount; l++)
                        {
                            if (intArray[i]+intArray[j]+intArray[k]+intArray[l] ==0)
                                {
                                    zeroCount++;
                                }
                            for (int m = l+1; m < subsetCount; m++)
                            {
                                if (intArray[i]+intArray[j]+intArray[k]+intArray[l]+intArray[m] ==0)
                                    {
                                        zeroCount++;
                                    }
                            }
                        }
                    }
			    }   
            }
            Console.WriteLine("The number of subset that result with zero is : {0}",zeroCount);
        }
    }

