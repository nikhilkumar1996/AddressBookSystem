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
        public void EditContact()
        {
            if (addressBook.Count != 0)
            {
                Console.WriteLine("Enter the First Name to modify other Details:");
                string firstname= Console.ReadLine();
                foreach (var person in addressBook)
                {
                    if (person.FirstName == firstname)
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Address ");
                            Console.WriteLine("Enter 4 to Change City ");
                            Console.WriteLine("Enter 5 to Change State ");
                            Console.WriteLine("Enter 6 to Change Zipcode ");
                            Console.WriteLine("Enter 7 to Change Phone Number ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Addressess = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.ZipCode = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name!");
                    }

                }


            }       Console.ReadKey();
            
        }
        public void Display()
        {
            foreach (var details in addressBook)
            {
                Console.WriteLine(details.FirstName);
                Console.WriteLine(details.LastName);
                Console.WriteLine(details.Addressess);
                Console.WriteLine(details.City);
                Console.WriteLine(details.State);
                Console.WriteLine(details.ZipCode);
                Console.WriteLine(details.PhoneNumber);
            }
            Console.ReadKey();
        }

       
        
    }
}
