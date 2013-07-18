//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

    class CharArrays
    {
        static void Main()
        {
            Console.Write("Please enter the first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Please enter the second word: ");
            string secondWord = Console.ReadLine();

            if (firstWord.CompareTo(secondWord) == -1)
            {
                Console.WriteLine("The first word is lexicographically before the second.");
            }
            if (firstWord.CompareTo(secondWord)==0)
            {
                Console.WriteLine("The words are lexicographically equal.");
            }
            if(firstWord.CompareTo(secondWord)==1)
            {
                Console.WriteLine("The second word is lexicographically before the first." );
            }
        }
    }
