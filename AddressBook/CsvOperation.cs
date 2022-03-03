using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CsvOperation
    {
        public static void CSVOperation(Dictionary<string, List<ListingPeople>> addressbooknames, int option)
        {
            //Store Csv File path in a string
            string csvFilePath = @"E:\github\AddressBookSystem\AddressBook\FileCsv.csv";
            string jsonfilePath = @"E:\github\AddressBookSystem\AddressBook\jsonFile.json";
            File.WriteAllText(csvFilePath, string.Empty);
            //Iterate over Dictionary Values
            foreach (KeyValuePair<string, List<ListingPeople>> kvp in addressbooknames)
            {
                //Open file in Append Mode for adding List elements
                using var stream = File.Open(csvFilePath, FileMode.Append);
                using var writer = new StreamWriter(stream);
                using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
                //Iterate over each value
                foreach (var value in kvp.Value)
                {
                    //Create List to add Records
                    List<ListingPeople> list = new List<ListingPeople>();
                    list.Add(value);
                    //Write List to CSV File
                    csvWriter.WriteRecords(list);
                }
                //Print a newline
                csvWriter.NextRecord();
            }
            //Reading a Csv File
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //Get all records from Csv File
                var records = csv.GetRecords<ListingPeople>().ToList();
                if (option == 1)
                {
                    foreach (ListingPeople member in records)
                    {

                        //To skip Headers in Csv File
                        if (member.firstName == "firstName")
                        {
                            Console.WriteLine("\n");
                            continue;
                        }
                        //Convert each Value to string and Print to Console
                        Console.WriteLine(member.ToString());
                    }

                }
                else
                {
                    //Create object for Json
                    Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                    using (StreamWriter stream = new StreamWriter(jsonfilePath))
                    using (JsonWriter jsonWriter = new JsonTextWriter(stream))
                    {
                        //Converting from List to Json Object
                        jsonSerializer.Serialize(jsonWriter, addressbooknames);
                    }

                    //Reading from Json File-> Converting from Json Object to List
                    Dictionary<string, List<ListingPeople>> jsonList = JsonConvert.DeserializeObject<Dictionary<string, List<ListingPeople>>>(File.ReadAllText(jsonfilePath));
                    foreach (KeyValuePair<string, List<ListingPeople>> i in jsonList)
                    {
                        Console.WriteLine("\nAddressBook Name: {0}", i.Key);
                        foreach (var j in i.Value)
                        {
                            Console.WriteLine(j.ToString());
                        }


                    }
                }



            }
        }
    }
}
