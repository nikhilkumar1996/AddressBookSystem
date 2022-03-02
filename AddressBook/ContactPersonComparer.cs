using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactPersonComparer : IComparer<ListingPeople>
    {
        //Constants 
        public enum sortBy
        {
            firstName,
            city,
            state,
            zip
        }
        public sortBy compareByFields;

        //Compare values of addressBook object x and y
        public int Compare(ListingPeople x, ListingPeople y)
        {
            switch (compareByFields)
            {
                case sortBy.firstName:
                    return x.firstName.CompareTo(y.firstName);
                case sortBy.city:
                    return x.city.CompareTo(y.city);
                case sortBy.state:
                    return x.state.CompareTo(y.state);
                case sortBy.zip:
                    return x.zipCode.CompareTo(y.zipCode);
                default: break;

            }
            //If given Invalid Option
            return x.firstName.CompareTo(y.firstName);

        }
    }
}
