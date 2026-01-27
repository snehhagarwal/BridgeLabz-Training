using System;
using System.Collections.Generic;
using System.Linq;

public class AddressBookUtility : IAddressBook{
    private List<AddressBookModel> contacts = new List<AddressBookModel>();

    private static Dictionary<string, AddressBookUtility> addressBooks
        = new Dictionary<string, AddressBookUtility>();

    private static Dictionary<string, List<AddressBookModel>> cityMap
        = new Dictionary<string, List<AddressBookModel>>();

    private static Dictionary<string, List<AddressBookModel>> stateMap
        = new Dictionary<string, List<AddressBookModel>>();

    public void DisplayWelcomeMessage(){
     Console.WriteLine("Welcome to Address Book Program");
    }

    // UC-1 & UC-2
    public void AddContact(){
        AddressBookModel person = new AddressBookModel();

        Console.Write("First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        person.LastName = Console.ReadLine();

        if (contacts.Any(c => c.Equals(person)))
            throw new DuplicateContactException("Contact already exists!");

        Console.Write("Address: ");
        person.Address = Console.ReadLine();

        Console.Write("City: ");
        person.City = Console.ReadLine();

        Console.Write("State: ");
        person.State = Console.ReadLine();

        Console.Write("Zip: ");
        person.Zip = Console.ReadLine();

        Console.Write("Phone: ");
        person.PhoneNumber = Console.ReadLine();

        Console.Write("Email: ");
        person.Email = Console.ReadLine();

        contacts.Add(person);

        if (!cityMap.ContainsKey(person.City))
            cityMap[person.City] = new List<AddressBookModel>();
        cityMap[person.City].Add(person);

        if (!stateMap.ContainsKey(person.State))
            stateMap[person.State] = new List<AddressBookModel>();
        stateMap[person.State].Add(person);

        Console.WriteLine("Contact Added Successfully!");
    }

    // UC-3
    public void EditContact(){
        Console.Write("Enter First Name to Edit: ");
        string name = Console.ReadLine();

        AddressBookModel person = contacts
            .FirstOrDefault(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (person == null)
            throw new Exception("Contact not found!");

        Console.Write("New Address: ");
        person.Address = Console.ReadLine();

        Console.Write("New Phone: ");
        person.PhoneNumber = Console.ReadLine();

        Console.WriteLine("Contact Updated!");
    }

    // UC-4
    public void DeleteContact(){
        Console.Write("Enter First Name to Delete: ");
        string name = Console.ReadLine();

        AddressBookModel person = contacts
            .FirstOrDefault(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (person == null)
            throw new Exception("Contact not found!");

        contacts.Remove(person);
        cityMap[person.City].Remove(person);
        stateMap[person.State].Remove(person);

        Console.WriteLine("Contact Deleted!");
    }

    // UC-5
    public void AddMultipleContacts(){
        char choice;
        do{
            try{
                AddContact();
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }

            Console.Write("Add another? (y/n): ");
            choice = Console.ReadLine().ToLower()[0];

        } while (choice == 'y');
    }

    // UC-6
    public static void CreateAddressBook() {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        if (addressBooks.ContainsKey(name))
            throw new Exception("Address Book already exists!");

        addressBooks[name] = new AddressBookUtility();
        Console.WriteLine("Address Book Created!");
    }

    public static AddressBookUtility SelectAddressBook(){
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        if (!addressBooks.ContainsKey(name))
            throw new AddressBookNotFoundException("Address Book not found!");

        return addressBooks[name];
    }

    // UC-11
    public void SortContactsByName(){
        contacts = contacts.OrderBy(c => c.FirstName).ToList();

        Console.WriteLine("Sorted Contacts:");
        foreach (var c in contacts)
            Console.WriteLine(c);
    }
}
