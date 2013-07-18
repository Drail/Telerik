using System;

class EmployeeID
{
    static void Main(string[] args)
    {
        string firstName = "Frank";
        string lastName = "Lampard";
        ushort age = 34;
        char gender = 'm';
        ulong id = 7906105808;
        ulong employeeID = 27560001;
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nI.D. Number: {4} \nUnique Employee Number: {5}", firstName, lastName, age, gender, id, employeeID);
    }
}