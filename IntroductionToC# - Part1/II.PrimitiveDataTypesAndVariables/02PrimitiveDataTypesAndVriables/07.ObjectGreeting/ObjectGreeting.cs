using System;

class ObjectGreeting
{
    static void Main(string[] args)
    {
        string a = "Hello,";
        string b = "world";
        object c = a + " " + b;
        string d = (string)c;
        Console.WriteLine("{0},\ntype casting: {1}", c, d);
    }
}