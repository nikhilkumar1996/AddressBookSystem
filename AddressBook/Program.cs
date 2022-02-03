using System;
namespace AddressBook
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Address Book System Program");
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name: ");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contacts.LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            contacts.Addressess = Console.ReadLine();
            Console.Write("Enter City : ");
            contacts.City = Console.ReadLine();
            Console.Write("Enter State : ");
            contacts.State = Console.ReadLine();
            Console.Write("Enter ZipCode: ");
            contacts.ZipCode = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contacts.PhoneNumber = Console.ReadLine();

        }
    }
}
