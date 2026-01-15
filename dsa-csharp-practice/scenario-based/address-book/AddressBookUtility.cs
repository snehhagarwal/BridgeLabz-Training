using System;

class AddressBookUtility : IAddressBook
{
    //UC-6 Multiple Address Books
    private int maxContacts = 100; // max per address book
    private AddressBookModel[] contacts = new AddressBookModel[100]; // array for contacts
    private int contactCount = 0; // current number of contacts in this book

    // LinkedList previously used till UC-3
    // private LinkedList<AddressBookModel> contacts = new LinkedList<AddressBookModel>();

    // Multiple Address Books
    private static int maxBooks = 10;
    private static AddressBookUtility[] addressBooks = new AddressBookUtility[maxBooks];
    private static string[] addressBookNames = new string[maxBooks];
    private static int bookCount = 0;

    // UC-7 Duplicate Check 
    private bool IsDuplicate(AddressBookModel person)
    {
        for (int i = 0; i < contactCount; i++)
        {
            if (contacts[i].Equals(person))
                return true;
        }
        return false;
    }

    //UC-2 Add Contact
    public void AddContact()
    {
        if (contactCount >= maxContacts)
        {
            Console.WriteLine("Address Book full.");
            return;
        }

        AddressBookModel person = new AddressBookModel();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

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

        contacts[contactCount++] = person;
        Console.WriteLine("Contact added successfully!");
    }

    //UC-3 Edit Contact
    public void EditContact(string firstName)
    {
        for (int i = 0; i < contactCount; i++)
        {
            if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter Address: ");
                contacts[i].Address = Console.ReadLine();

                Console.Write("Enter City: ");
                contacts[i].City = Console.ReadLine();

                Console.Write("Enter State: ");
                contacts[i].State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                contacts[i].Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                contacts[i].PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Email: ");
                contacts[i].Email = Console.ReadLine();

                Console.WriteLine("Contact updated.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    //UC-4 Delete Contact
    public void DeleteContact(string firstName)
    {
        for (int i = 0; i < contactCount; i++)
        {
            if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < contactCount - 1; j++)
                    contacts[j] = contacts[j + 1]; // shift left
                contacts[--contactCount] = null;
                Console.WriteLine("Contact deleted successfully.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    //UC-5 Add Multiple Contacts
    public void AddMultipleContacts()
    {
        Console.Write("How many persons to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter details for person " + (i + 1));
            AddContact();
        }
    }

    //UC-6 Create Address Book
    public static AddressBookUtility CreateAddressBook()
    {
        if (bookCount >= maxBooks)
        {
            Console.WriteLine("Maximum address books reached.");
            return null;
        }

        Console.Write("Enter unique Address Book name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book already exists.");
                return addressBooks[i];
            }
        }

        addressBookNames[bookCount] = name;
        addressBooks[bookCount] = new AddressBookUtility();
        bookCount++;

        Console.WriteLine("Address Book created.");
        return addressBooks[bookCount - 1];
    }

    // UC-6 Select Address Book
    public static AddressBookUtility SelectAddressBook()
    {
        Console.Write("Enter Address Book name to select: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book selected.");
                return addressBooks[i];
            }
        }

        Console.WriteLine("Address Book not found.");
        return null;
    }

    //UC-8 
    public static void SearchByCityOrState()
    {
        Console.Write("Enter City or State to search: ");
        string input = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                AddressBookModel p = book.contacts[j];
                if (p.City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                    p.State.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        "Address Book: " + addressBookNames[i] +
                        " | " + p.FirstName + " " + p.LastName +
                        ", " + p.City + ", " + p.State +
                        ", " + p.PhoneNumber
                    );
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No person found.");
    }

    //UC-9 View Persons by City/State using arrays
    public static void ViewPersonsByCityOrState()
    {
        Console.WriteLine("View by: 1. City  2. State");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Collect unique locations
        int maxLocations = 0;
        for (int i = 0; i < bookCount; i++)
            maxLocations += addressBooks[i].contactCount;

        string[] uniqueLocations = new string[maxLocations];
        int uniqueCount = 0;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                string key = choice == 1 ? book.contacts[j].City : book.contacts[j].State;
                bool exists = false;
                for (int k = 0; k < uniqueCount; k++)
                {
                    if (uniqueLocations[k].Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                    uniqueLocations[uniqueCount++] = key;
            }
        }

        // Print persons for each location
        for (int i = 0; i < uniqueCount; i++)
        {
            string loc = uniqueLocations[i];
            Console.WriteLine("\n" + (choice == 1 ? "City: " : "State: ") + loc);

            for (int j = 0; j < bookCount; j++)
            {
                AddressBookUtility book = addressBooks[j];
                for (int k = 0; k < book.contactCount; k++)
                {
                    AddressBookModel p = book.contacts[k];
                    string key = choice == 1 ? p.City : p.State;
                    if (key.Equals(loc, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("- " + p.FirstName + " " + p.LastName + " (Book: " + addressBookNames[j] + ")");
                }
            }
        }
    }

    // UC-10 Count Contacts by City/State
    public static void CountContactsByCityOrState()
    {
        Console.WriteLine("Count by: 1. City  2. State");
        int choice = Convert.ToInt32(Console.ReadLine());

        int maxLocations = 0;
        for (int i = 0; i < bookCount; i++)
            maxLocations += addressBooks[i].contactCount;

        string[] uniqueLocations = new string[maxLocations];
        int uniqueCount = 0;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                string key = choice == 1 ? book.contacts[j].City : book.contacts[j].State;
                bool exists = false;
                for (int k = 0; k < uniqueCount; k++)
                {
                    if (uniqueLocations[k].Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                    uniqueLocations[uniqueCount++] = key;
            }
        }

        for (int i = 0; i < uniqueCount; i++)
        {
            string loc = uniqueLocations[i];
            int count = 0;

            for (int j = 0; j < bookCount; j++)
            {
                AddressBookUtility book = addressBooks[j];
                for (int k = 0; k < book.contactCount; k++)
                {
                    string key = choice == 1 ? book.contacts[k].City : book.contacts[k].State;
                    if (key.Equals(loc, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }

            Console.WriteLine((choice == 1 ? "City: " : "State: ") + loc + " => " + count + " persons");
        }
    }

    // UC-11 Sort Contacts by Name
    public void SortContactsByName()
    {
        for (int i = 0; i < contactCount - 1; i++)
        {
            for (int j = 0; j < contactCount - i - 1; j++)
            {
                string name1 = contacts[j].FirstName + " " + contacts[j].LastName;
                string name2 = contacts[j + 1].FirstName + " " + contacts[j + 1].LastName;

                if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    AddressBookModel temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nContacts sorted alphabetically:");
        for (int i = 0; i < contactCount; i++)
            Console.WriteLine(contacts[i].FirstName + " " + contacts[i].LastName + " | " + contacts[i].Address + ", " + contacts[i].City + ", " + contacts[i].State + " | " + contacts[i].PhoneNumber + " | " + contacts[i].Email);
    }
}
