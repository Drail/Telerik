//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

    class SequenceWithSum
    {
        static void Main()
        {
             Console.Write("Please enter the lenght of the array N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the sum S: ");
            int s = int.Parse(Console.ReadLine()); 
            int start = 0;
            int lenght = 0;
            bool end = false;
            int[] array = new int[n];
            int tempSum = array[0];
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            } 

            for (int m = 0; m < array.Length; m++)
            {
                if (end==true)
                {
                    break;
                }
                tempSum = array[m];

                for (int l = m+1; l < array.Length; l++)
                {
                    tempSum += array[l];
                    if (tempSum < s)
                    {
                        lenght++;
                    }
                    if (tempSum==s)
	                {
		                start = m;
                        lenght++;
                        end = true;
                        break;
	                }
                    if (tempSum > s)
	                {
		                lenght = 1;
                        break;
	                }
                }
            }

            Console.WriteLine();
            Console.Write("{");
            for (int k = start; k < start+lenght; k++)
			{
			  Console.Write(array[k] + " ");
			}
            Console.WriteLine("}");

        }
    }
