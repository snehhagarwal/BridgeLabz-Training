using System;
using System.Collections.Generic;

class AddressBookUtility : IAddressBook
{
    //UC-6 Multiple Address Book
    int n = Convert.ToInt32(Console.ReadLine());
    private static AddressBookUtility[] addressBooks = new AddressBookUtility[n];
    private static string[] addressBookNames = new string[n];
    private static int bookCount = 0;
    private LinkedList<AddressBookModel> contacts = new LinkedList<AddressBookModel>();

    //UC-7 Duplicate Check
    private bool IsDuplicate(AddressBookModel person)
    {
        foreach (AddressBookModel existing in contacts)
        {
            if (existing.Equals(person))
            {
                return true;
            }
        }
        return false;
    }

    //UC-2 Add A New Contact
    public void AddContact()
    {
        AddressBookModel person = new AddressBookModel();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        //UC-7 Check
        if (IsDuplicate(person))
        {
            Console.WriteLine("Duplicate contact found.");
            return;
        }

        Console.Write("Enter Address: ");
        person.Address = Console.ReadLine();

        Console.Write("Enter City: ");
        person.City = Console.ReadLine();

        Console.Write("Enter State: ");
        person.State = Console.ReadLine();

        Console.Write("Enter Zip: ");
        person.Zip = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email: ");
        person.Email = Console.ReadLine();

        contacts.AddLast(person);
        Console.WriteLine("\nContact added successfully!");
    }

    //UC-3 Edit existing contact using name
    public void EditContact(string firstName)
    {
        foreach (AddressBookModel person in contacts)
        {
            if (person.FirstName.Equals(firstName))
            {
                Console.Write("Enter Address: ");
                person.Address = Console.ReadLine();

                Console.Write("Enter new city: ");
                person.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                person.State = Console.ReadLine();

                Console.Write("Enter new zip: ");
                person.Zip = Console.ReadLine();

                Console.Write("Enter new Phone Number: ");
                person.PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Email: ");
                person.Email = Console.ReadLine();

                Console.WriteLine("Contact updated");
                return;
            }
        }
        Console.WriteLine("Contact not found");
    }

    //UC-4 Delete contact using name
    public void DeleteContact(string firstName)
    {
        foreach (AdressBookModel person in contacts)
        {
            if (person.FirstName.Equals(firstName))
            {
                contacts.Remove(person);
                Console.WriteLine("Contact deleted successfully");
                return;
            }
        }
        Console.WriteLine("Contact not found");
    }

    // UC-5 Add Multiple Person using Array
    public void AddMultipleContacts()
    {
        Console.Write("How many person you want to add");
        int n = Convert.ToInt32(Console.ReadLine());

        AddressBookModel[] arr = new AddressBookModel[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter details for person: ");
            AddressBookModel person = new AddressBookModel();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            arr[i] = person;
        }

        foreach (AddressBookModel person in arr)
        {
            contacts.AddLast(person);
        }

        Console.WriteLine("Multiple contacts added");
    }

    //UC-6 creating new AddressBook
    public static AddressBookUtility CreateAddressBook()
    {
        Console.Write("Enter unique Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name))
            {
                Console.WriteLine("Address Book exists");
                return addressBooks[i];
            }
        }

        addressBookNames[bookCount] = name;
        addressBooks[bookCount] = new AddressBookUtility();
        bookCount++;

        Console.WriteLine("Address Book created");
        return addressBooks[bookCount - 1];
    }

    //select address book which one to use
    public static AddressBookUtility SelectAddressBook()
    {
        Console.Write("Enter Book Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name))
            {
                Console.WriteLine("Address book selected");
                return addressBooks[i];
            }
        }

        Console.WriteLine("Address Book not found");
        return null;
    }

    //UC-8 Search person by City or State across all Address Books
    public static void SearchByCityOrState()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No Address Books Available");
            return;
        }

        Console.Write("Enter City or State to search: ");
        string input = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            foreach (AddressBookModel person in book.contacts)
            {
                if (person.City.Equals(input, StringComparison.OrdinalIgnoreCase) || person.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Address Book: " + addressBookNames[i]);
                    Console.WriteLine("Name: " + person.FirstName + " " + person.LastName);
                    Console.WriteLine("Address: " + person.Address);
                    Console.WriteLine("City: " + person.City);
                    Console.WriteLine("State: " + person.State);
                    Console.WriteLine("Zip: " + person.Zip);
                    Console.WriteLine("Phone: " + person.Phone);
                    Console.WriteLine("Email: " + person.Email);
                    found = true;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No person found in the given city/state");
        }
    }

    //UC-9 View Persons by City or State using Arrays
    // UC-9: View Persons by City or State using only arrays
    public static void ViewPersonsByCityOrState()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.WriteLine("View by: 1. City  2. State");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Step 1: Estimate maximum unique locations (worst case all contacts are unique)
        int maxLocations = 0;
        for (int i = 0; i < bookCount; i++)
        {
            maxLocations += addressBooks[i].contacts.Count;
        }

        string[] uniqueLocations = new string[maxLocations];
        int uniqueCount = 0;

        // Step 2: Collect unique cities or states
        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            foreach (AddressBookModel person in book.contacts)
            {
                string key = choice == 1 ? person.City : person.State;

                // Check if already added
                bool exists = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (uniqueLocations[j].Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    uniqueLocations[uniqueCount] = key;
                    uniqueCount++;
                }
            }
        }

        // Step 3: For each unique location, list persons
        for (int i = 0; i < uniqueCount; i++)
        {
            string location = uniqueLocations[i];
            Console.WriteLine($"\n{(choice == 1 ? "City" : "State")}: {location}");

            for (int j = 0; j < bookCount; j++)
            {
                AddressBookUtility book = addressBooks[j];
                foreach (AddressBookModel person in book.contacts)
                {
                    string key = choice == 1 ? person.City : person.State;
                    if (key.Equals(location, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"- {person.FirstName} {person.LastName} (Address Book: {addressBookNames[j]})");
                    }
                }
            }
        }
    }

    // UC-10: Count number of persons by City or State using arrays
    public static void CountContactsByCityOrState()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No Address Books available.");
            return;
        }

        Console.WriteLine("Count contacts by: 1. City  2. State");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Step 1: Collect unique locations
        int maxLocations = 0;
        for (int i = 0; i < bookCount; i++)
            maxLocations += addressBooks[i].contacts.Count;

        string[] uniqueLocations = new string[maxLocations];
        int uniqueCount = 0;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            foreach (AddressBookModel person in book.contacts)
            {
                string key = choice == 1 ? person.City : person.State;

                // Check if already in uniqueLocations
                bool exists = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (uniqueLocations[j].Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    uniqueLocations[uniqueCount] = key;
                    uniqueCount++;
                }
            }
        }

        // Step 2: Count contacts for each unique location
        for (int i = 0; i < uniqueCount; i++)
        {
            string location = uniqueLocations[i];
            int count = 0;

            for (int j = 0; j < bookCount; j++)
            {
                AddressBookUtility book = addressBooks[j];
                foreach (AddressBookModel person in book.contacts)
                {
                    string key = choice == 1 ? person.City : person.State;
                    if (key.Equals(location, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"{(choice == 1 ? "City" : "State")}: {location}  => Number of Persons: {count}");
        }
    }
}