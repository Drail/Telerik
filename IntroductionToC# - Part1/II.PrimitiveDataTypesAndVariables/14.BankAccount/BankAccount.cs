/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
 * to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;

    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine(new string('=', 50)); // Personal information block
            string firstName = "John";
            string middleName = "Smith";
            string lastName = "Doe";
            object fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine("Presonal Information:");
            Console.WriteLine();
            Console.WriteLine("Full Name: {0}", fullName);

            Console.WriteLine(new string('=', 50)); // Account information block
            decimal bankBalance = 74000.003M;
            string bankName = "DSK Bank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            string bicCode = "STSABGSF";
            Console.WriteLine("Account Information:");
            Console.WriteLine();
            Console.WriteLine("Bank: {0} \nIBAN: {1} \nBIC: {2} \nFunds Total: {3}", bankName, iban, bicCode, bankBalance);

            Console.WriteLine(new string('=', 50)); // Credit card list block
            long creditCard1 = 4716433130051931;
            long creditCard2 = 4916673602030263;
            long creditCard3 = 4916923757747785;
            Console.WriteLine("Credit Card list:");
            Console.WriteLine();
            Console.WriteLine("First card number: {0} \nSecond card number: {1} \nThird card number: {2}", creditCard1, creditCard2, creditCard3);
            Console.WriteLine(new string('=', 50));
        }
    }

