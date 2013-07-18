/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
 * first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). D
 * eclare the variables needed to keep the information for a single employee using appropriate data types and descriptive names. */


using System;

    class EmployeeRecord
    {
        static void Main()
        {
            Console.WriteLine("Please fill the form for your employee card below");

            Console.Write("Please enter your first name:");
            string firstName = (Console.ReadLine());
            Console.Write("Please enter your last name:");
            string lastName = (Console.ReadLine());
            Console.Write("Please enter your age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Please enter your gender (F or M):");
            string gender = (Console.ReadLine());
            Console.Write("Please enter your ID number:");
            string idNumber = (Console.ReadLine());
            Console.Write("Please enter your unique employee number (from 1 to 9999):");
            ushort employeeNumber = ushort.Parse(Console.ReadLine());
            Console.WriteLine("      ");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Employee full name: {0} {1}", firstName, lastName);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("Age: {0} Gender: {1}.", age, gender);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("ID number: {0}", idNumber);
            Console.WriteLine("Employee number:2756{0}", employeeNumber.ToString("D4"));
            Console.WriteLine(new string('=', 50));

        }
    }

