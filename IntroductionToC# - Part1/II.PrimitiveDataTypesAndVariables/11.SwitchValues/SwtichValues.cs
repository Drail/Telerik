﻿//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

    class SwitchValues
    { 
        static void Main()
        {
            byte a = 5;
            byte b = 10;
            byte c;

            c = a;
            a = b;
            b = c;
            Console.WriteLine("The initial values: \na is 5 \nb is 10 \nNew Values: \na is {0} \nb is {1}", a,b );
        }
    }
