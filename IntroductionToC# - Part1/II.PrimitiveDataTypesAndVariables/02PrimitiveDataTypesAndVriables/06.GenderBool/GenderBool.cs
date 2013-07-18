using System;


class GenderBool
{
    static void Main()
    {
        bool isFemale = false;

        switch (isFemale)
        {
            case true:
                Console.WriteLine("Hey, girl! What's your name?");
                break;
            case false:
                Console.WriteLine("What's up dude?");
                break;
        }
    }
}