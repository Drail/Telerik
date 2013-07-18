/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
 * age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console. */

using System;

    class CompanyRecord
    {
        static void Main()
        {
            Console.Write("Please enter the name of the company: ");
            string companyName = Console.ReadLine();
            Console.Write("Please enter the address of the company: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please enter the phone number of the company: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Please enter the fax number of the company: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Please enter the web site of the company: ");
            string webSite = Console.ReadLine();
            Console.Write("Please enter the first name of the manager: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please enter the last name of the manager: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Please enter the age of the manager: ");
            string managerAge = Console.ReadLine();
            Console.Write("Please enter the phone number of the manager: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(new string('=',50));
            Console.WriteLine("Company: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone: {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web Site: {0}", webSite);
            Console.WriteLine(new string('=',50));
            Console.WriteLine("Manager: {0} {1}",managerFirstName, managerLastName);
            Console.WriteLine("Age: {0}", managerAge);
            Console.WriteLine("Phone: {0}", managerPhone);
        }
    }