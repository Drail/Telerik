//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


using System;

    class CharArray
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            for (char i = 'A'; i <= 'Z'; i++) alphabet[i - 65] = i;

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            for (int m = 0; m < word.Length; m++)
            {
                Console.WriteLine("Letter '{0}' -> index: {1} / ASCII: {2}", word[m],
                Array.IndexOf(alphabet, char.ToUpperInvariant(word[m])), (int)word[m]);
            }

        }
    }
