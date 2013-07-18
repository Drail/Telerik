/*Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it 
 * with the concatenation of the first two variables (mind adding an interval). 
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;

    class HelloWorld2
    {
        static void Main()
        {
            string greeting = "Hello";
            string sautation = "World";
            object helloWorld = greeting + " " + sautation;
            Console.WriteLine(helloWorld+"!");
            string castedGreeting = (string)helloWorld; //Performing type casting from object to string.
            Console.WriteLine(castedGreeting+"!");
        }
    }
