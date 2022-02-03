using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ListingPeople
    {
        List<Contacts> addressBook=new List<Contacts>();
        public void CreateContacts()
        {
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
            Console.WriteLine("Contacts Created:" + contacts.FirstName + "\n" + contacts.LastName + "\n" + contacts.Addressess + "\n" + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n" + contacts.PhoneNumber);
            addressBook.Add(contacts);
            
        }
            
    }
}
