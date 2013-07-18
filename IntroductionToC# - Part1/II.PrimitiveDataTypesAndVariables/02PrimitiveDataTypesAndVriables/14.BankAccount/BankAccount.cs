using System;


class bankAccount
{
    static void Main()
    {
        string firstName = "Brad";
        string middleName = "Brat mi";
        string lastName = "Pitt";
        decimal moneyBalance = 894999.59m;
        string bankName = "Tokuda Bank";
        string IBAN = "GB29";
        string BIC = "AB 1212";
        string CC1 = "MC 123455 ";
        string CC2 = "DR 324234 ";
        string CC3 = "BL 573843 ";
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", firstName, middleName, lastName, moneyBalance, bankName, IBAN, BIC, CC1, CC2, CC3);
    }
}