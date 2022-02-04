using System;
namespace AddressBook
{
    public static class Program
    {
        public static void Main()
        {

            Console.WriteLine("Welcome To Address Book System");
            ListingPeople LP=new ListingPeople();
            Console.WriteLine("Enter How many Contacts you want to Add");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                Console.WriteLine("Create a Contact");
                LP.CreateContacts();
            }

            LP.Display();
            LP.EditContact();
            LP.Display();
            LP.DeleteContact();
            LP.Display();




        }
    }
}
