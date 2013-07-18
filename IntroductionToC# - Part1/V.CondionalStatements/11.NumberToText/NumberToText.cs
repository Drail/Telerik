// * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 

using System;

    class NumberToText
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number (0-999): ");
            int number = int.Parse(Console.ReadLine());
            int endNumber = number;
            string result = "The number is: ";
            if (number >= 0 && number <= 999)
            {
                int hundreds = number / 100;
                switch (hundreds)
                {
                    case 9:
                        number = number - 900;
                        result += "Nine hundred ";
                        break;
                    case 8:
                        number = number - 800;
                        result += "Eight hundred ";
                        break;
                    case 7:
                        number = number - 700;
                        result += "Seven hundred ";
                        break;
                    case 6:
                        number = number - 600;
                        result += "Six hundred ";
                        break;
                    case 5:
                        number = number - 500;
                        result += "Five hundred";
                        break;
                    case 4:
                        number = number - 400;
                        result += "Four hundred ";
                        break;
                    case 3:
                        number = number - 300;
                        result += "Three hundred ";
                        break;
                    case 2:
                        number = number - 200;
                        result += "Two hundred ";
                        break;
                    case 1:
                        number = number - 100;
                        result += "One hundred ";
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
                int tens = number / 10;

                switch (tens)
                {
                    case 9:
                        number = number - 90;
                        result += "Ninety ";
                        break;
                    case 8:
                        number = number - 80;
                        result += "Eighty ";
                        break;
                    case 7:
                        number = number - 70;
                        result += "Seventy ";
                        break;
                    case 6:
                        number = number - 60;
                        result += "Sixty ";
                        break;
                    case 5:
                        number = number - 50;
                        result += "Fifty ";
                        break;
                    case 4:
                        number = number - 40;
                        result += "Fourty ";
                        break;
                    case 3:
                        number = number - 30;
                        result += "Thirty ";
                        break;
                    case 2:
                        number = number - 20;
                        result += "Twenty ";
                        break;
                    case 1:
                        number = number - 10;
                        switch (number)
                        {
                            case 9:
                                result += "Nineteen";
                                break;
                            case 8: result += "Eighteen";
                                break;
                            case 7:
                                result += "Seventeen";
                                break;
                            case 6: result += "Sixteen";
                                break;
                            case 5: result += "Fifteen";
                                break;
                            case 4:
                                result += "Fourteen";
                                break;
                            case 3:
                                result += "Thirteen";
                                break;
                            case 2:
                                result += "Twelve";
                                break;
                            case 1: result += "Eleven";
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("Out of range");
                                break;
                        }
                        break;
                    case 0:
                        result += "and ";
                        break;
                    default:
                        break;
                }
                int ones = number;
                switch (ones)
                {
                    case 9:
                        result += "Nine.";
                        break;
                    case 8:
                        result += "Eighty.";
                        break;
                    case 7:
                        result += "Seven.";
                        break;
                    case 6:
                        result += "Six.";
                        break;
                    case 5:
                        result += "Five.";
                        break;
                    case 4:
                        result += "Four.";
                        break;
                    case 3:
                        result += "Three.";
                        break;
                    case 2:
                        result += "Two.";
                        break;
                    case 1:
                        result += "One.";
                        break;
                    case 0:
                        result += ".";
                        break;
                    default:
                        break;
                }
                if (endNumber == 0)
                {
                    result = "Zero.";
                }
                Console.WriteLine("{0} -> {1}", endNumber, result);
            }
            else
            {
                Console.WriteLine("Out of Range!");
            }
        }
    }