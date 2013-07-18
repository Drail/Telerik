using System;

class PrintFullName
{
    static void Main(string[] args)
    {
        string FName = "John";
        string LName = "Doe";
        string fullName = FName + " " + LName;
        Console.WriteLine("Hello, " + FName + "!");
        Console.WriteLine("Your full name is " + fullName + ".");
    }
}
