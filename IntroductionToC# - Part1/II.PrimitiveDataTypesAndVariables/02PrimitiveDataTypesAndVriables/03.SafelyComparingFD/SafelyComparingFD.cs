using System;

class SafelyComparingFD
{
    static void Main()
    {
        double firstNumber, secondNumber, precision = 0.000001;
        bool result;

        firstNumber = 5.3;
        secondNumber = 6.01;
        result = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine("For a={0} and b={1} with precision={2}, result is: {3}", firstNumber, secondNumber, precision, result);

        firstNumber = 5.00000001;
        secondNumber = 5.00000003;
        result = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine("For a={0} and b={1} with precision={2}, result is: {3}", firstNumber, secondNumber, precision, result);
    }
}
