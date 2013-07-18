using System;
using System.Text;

class TriangleCicles
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyrightSymbol = (char)0xA9;
        int columnNumber = 10;
        int rowNumber = 3;
        int character = 1;
        for (int i = 0; i < rowNumber; i++)
        {
            Console.Write(new string(' ', columnNumber - i - 1));
            Console.Write(new string(copyrightSymbol, i * 2 + 1));
            character += 2;
            Console.WriteLine();
        }
    }
}