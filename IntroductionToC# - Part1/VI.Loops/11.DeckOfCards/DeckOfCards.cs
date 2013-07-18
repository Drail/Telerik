//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.


using System;

    class DeckOfCards
    {
        static void Main()
        {
            string color;
            string value;
            

            for (int c = 1; c < 5; c++)
            {
                switch (c)
                {
                    case 1:
                        color = "s";
                        break;
                    case 2:
                        color = "h";
                        break;
                    case 3:
                        color = "d";
                        break;
                    case 4:
                        color = "c";
                        break;
                    default:
                        color = c.ToString();
                        break;
                }
                for (int v = 2; v < 15; v++)
                {
                    switch (v)
                    {   
                    
                        case 11:
                            value = "J";
                            break;
                        case 12:
                            value = "Q";
                            break;
                        case 13:
                            value = "K";
                            break;
                        case 14:
                            value = "A";
                            break;
                        default:
                            value = v.ToString();
                            break;
                    }
                    Console.WriteLine(value + color);
                }               
            }
            
        }
    }
