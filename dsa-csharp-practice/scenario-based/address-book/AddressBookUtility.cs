using System;
using System.Collections.Generic;

class AddressBookUtility : IAddressBook
{
    //UC-6 Multiple Address Book
    int n=Convert.ToInt32(Console.ReadLine());
    private static AddressBookUtility[] addressBooks=new AddressBookUtility[n];
    private static string[] addressBookNames=new string[n];
    private static int bookCount=0;
    private LinkedList<AddressBookModel> contacts = new LinkedList<AddressBookModel>();

    //UC-2 Add A New Contact
    public void AddContact()
    {
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

            arr[i]=person;
        }

        foreach(AddressBookModel person in arr)
        {
            contacts.AddLast(person);
        }

        Console.WriteLine("Multiple contacts added");
    }

    //UC-6 creating new AddressBook
    public static AddressBookUtility CreateAddressBook()
    {
        Console.Write("Enter unique Name: ");
        string name=Console.ReadLine();

        for(int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name))
            {
                Console.WriteLine("Address Book exists");
                return addressBooks[i];
            }
        }

        addressBookNames[bookCount]=name;
        addressBooks[bookCount]=new AddressBookUtility();
        bookCount++;

        Console.WriteLine("Address Book created");
        return addressBooks[bookCount-1];
    }

    //select address book which one to use
    public static AddressBookUtility SelectAddressBook()
    {
        Console.Write("Enter Book Name: ");
        string name=Console.ReadLine();

        for(int i = 0; i < bookCount; i++)
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

}