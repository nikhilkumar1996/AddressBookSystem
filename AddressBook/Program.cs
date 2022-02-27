using System;
namespace AddressBook
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            ListingPeople listingPeople = new ListingPeople("Nikhil", "kumar", "FlatNo2:BuildingA:Talegaon Dhabhade", "pune", "Maharashtra", "410507", "9867382923", "nk123@gmail.com");

            switch (Console.ReadLine())
            {

                case "1":
                    listingPeople.GetCustomer();
                    listingPeople.Display();
                    break;
                case "2":
                    listingPeople.GetCustomer();
                    listingPeople.Modify();
                    listingPeople.Display();
                    break;
                case "3":
                    listingPeople.GetCustomer();
                    listingPeople.Display();
                    break;
                case "4":
                    listingPeople.GetCustomer();
                    listingPeople.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }



        }
    }
}



    
