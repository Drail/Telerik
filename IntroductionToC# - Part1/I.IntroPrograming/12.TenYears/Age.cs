using System;

class TenYears
{
    static void Main()
    {
        Console.Write("Please, enter your age:");
        int myAge = int.Parse(Console.ReadLine());
        myAge += 10;
        Console.WriteLine("In ten years you'll be " +myAge+" years old.", myAge);
    }
}
