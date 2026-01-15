using System;
using System.Collections.Generic;

class AddressBookUtility : IAddressBook
{
    private LinkedList<AddressBookModel> contacts=new LinkedList<AddressBookModel>();

    //UC-2 Add A New Contact
    public void AddContact()
    {
        AddressBookModel person=new AddressBookModel();

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
        foreach(AddressBookModel person in contacts)
        {
            if (person.FirstName.Equals(firstName))
            {
                Console.Write("Enter Address: ");
                person.Address=Console.ReadLine();

                Console.Write("Enter new city: ");
                person.City=Console.ReadLine();

                Console.Write("Enter New State: ");
                person.State=Console.ReadLine();

                Console.Write("Enter new zip: ");
                person.Zip=Console.ReadLine();

                Console.Write("Enter new Phone Number: ");
                person.PhoneNumber=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Email: ");
                person.Email=Console.ReadLine();

                Console.WriteLine("Contact updated");
                return;
            }
        }
        Console.WriteLine("Contact not found");
    }

    //UC-4 Delete contact using name
    public void DeleteContact(string firstName)
    {
        foreach(AdressBookModel person in contacts)
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

    
}