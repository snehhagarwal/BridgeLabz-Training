using System;

class AddressBookMenu
{
    public void Start()
    {
        //before uc-4 used
        // IAddressBook utility=new AddressBookUtility();
        AddressBookUtility curr = null;
        int choice;

        do
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Add Contact");
            Console.WriteLine("4. Add Multiple Contacts");
            Console.WriteLine("5. Edit Contact");
            Console.WriteLine("6. Delete Contact");
            Console.WriteLine("7. Search Person by City/State");
            Console.WriteLine("8. View Persons by City/State");
            Console.WriteLine("9. Count Contacts by City/State");
            Console.WriteLine("10. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    currentBook = AddressBookUtility.CreateAddressBook();
                    break;

                case 2:
                    currentBook = AddressBookUtility.SelectAddressBook();
                    break;

                case 3:
                    if (currentBook != null)
                    {
                        currentBook.AddContact();
                    }
                    else
                    {
                        Console.WriteLine("Please create or select an Address Book first");
                    }
                    break;

                case 4:
                    if (currentBook != null)
                    {
                        currentBook.AddMultipleContacts();
                    }
                    else
                    {
                        Console.WriteLine("Please create or select an Address Book first");
                    }
                    break;

                case 5:
                    Console.Write("Enter First Name: ");
                    currentBook?.EditContact(Console.ReadLine());
                    break;

                case 6:
                    Console.Write("Enter First Name: ");
                    currentBook?.DeleteContact(Console.ReadLine());
                    break;

                case 7:
                    AddressBookUtility.SearchByCityOrState();
                    break;

                case 8:
                    AddressBookUtility.ViewPersonsByCityOrState();
                    break;

                case 9:
                    AddressBookUtility.CountByCityOrState();
                    break;
                    
                case 10:
                    Console.WriteLine("Exit the program");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 4);
    }
}