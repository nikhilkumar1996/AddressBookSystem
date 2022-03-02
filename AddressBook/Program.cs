using System;
namespace AddressBook
{
    public class Program
    {
        public static Dictionary<string, List<ListingPeople>> addressBook = new Dictionary<string, List<ListingPeople>>();
        public static Dictionary<string, List<ListingPeople>> City = new Dictionary<string, List<ListingPeople>>();
        public static Dictionary<string, List<ListingPeople>> State = new Dictionary<string, List<ListingPeople>>();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book System!");
            Console.WriteLine("Enter the number of address books: ");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the address book name : ");
                string addressbookname = Console.ReadLine();
                ListingPeople ListingPeople = new ListingPeople();
                Console.WriteLine("Enter the no of contacts in the address book: ");
                int noOfContact = Convert.ToInt32(Console.ReadLine());

                while (noOfContact > 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");

                    Console.Write("Enter First Name: ");
                    string FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string LastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    string PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Address : ");
                    string Addresses = Console.ReadLine();

                    Console.Write("Enter City : ");
                    string City = Console.ReadLine();

                    Console.Write("Enter State : ");
                    string State = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    string ZipCode = Console.ReadLine();

                    Console.Write("Enter EmailId: ");
                    string EmailId = Console.ReadLine();
                    //Calling the getcustomer method and store it dictionary
                    ListingPeople.GetCustomer(FirstName, LastName, PhoneNumber, Addresses, City, State, ZipCode, EmailId);
                    noOfContact--;
                    //addressBook.Add(addressbookname, ListingPeople.people);
                    Console.WriteLine(" ");
                    ListingPeople.Display();
                }
                Console.WriteLine("1.To modify the details");
                Console.WriteLine("2.To remove the details");
                Console.WriteLine("3.city or state");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ListingPeople.Modify();
                        Console.WriteLine(" ");
                        ListingPeople.Display();
                        break;
                    case 2:
                        ListingPeople.RemovePeople();
                        Console.WriteLine(" ");
                        ListingPeople.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter 1-To Search a person through a City");
                        Console.WriteLine("Enter 2-To Search a person through a State");
                        Console.WriteLine("Enter 3-To view a person by state list or city list");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {

                            case 1:
                                SearchAddress(opt);
                                break;
                            case 2:
                                SearchAddress(opt);
                                break;
                            case 3:
                                ListingPeople.DisplayCityorState();

                                break;
                            default:
                                Console.WriteLine("Invalid Option!");
                                break;
                        }
                        break;
                }
                //Checking the address book name is already exist or not
                if (addressBook.ContainsKey(addressbookname))
                {
                    Console.WriteLine("Existing address book name");
                    return;
                }
                //If not add it in dictionary
                else
                {
                    addressBook.Add(addressbookname, ListingPeople.people);
                }
                noOfBooks++;
                //Displaying the address book names
                foreach (KeyValuePair<string, List<ListingPeople>> addr in addressBook)
                {
                    Console.WriteLine("The address Books are:{0}", addr.Key);

                }
            }
            //Searching and sorting operations based on city,state,name,zipcode
            Console.WriteLine("Enter 1-To Search a person through a City");
            Console.WriteLine("Enter 2-To Search a person through a State");
            Console.WriteLine("Enter 3-To view a person by state list or city list");
            Console.WriteLine("Enter 4-Sort Contact People");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {

                case 1:
                    SearchAddress(opt);
                    break;
                case 2:
                    SearchAddress(opt);
                    break;
                case 3:
                    ListingPeople.DisplayCityorState();
                    break;
                case 4:
                    ListingPeople.SortContactPerson(addressBook);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
            //Search the person through city or state
            static void SearchAddress(int option)
            {
                string city, state;
                if (option == 1)
                {
                    Console.WriteLine("Enter the City Name");
                    city = Console.ReadLine();
                    foreach (KeyValuePair<string, List<ListingPeople>> kvp in addressBook)
                    {
                        ListingPeople.StoreCityList(kvp.Key, kvp.Value, city);

                    }
                    if (option == 2)
                    {
                        Console.WriteLine("Enter the City Name");
                        state = Console.ReadLine();
                        foreach (KeyValuePair<string, List<ListingPeople>> kvp in addressBook)
                        {
                            ListingPeople.StoreStateList(kvp.Key, kvp.Value, state);
                        }
                    }
                }
            }
        }
    } 
}
    




    
