using System;

public class AddressBookMenu{
    private AddressBookUtility utility;
    private int choice;

    public void Start(){
        Console.WriteLine("Welcome to Address Book Program");

        do {
            ShowMenu();
            choice = Convert.ToInt32(Console.ReadLine());

            try{
                HandleChoice(choice);
            }
            catch (Exception ex){
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (choice != 8);
    }

    private void ShowMenu(){
        Console.WriteLine("\n------ MENU ------");
        Console.WriteLine("1. Create Address Book");
        Console.WriteLine("2. Select Address Book");
        Console.WriteLine("3. Add Contact");
        Console.WriteLine("4. Add Multiple Contacts");
        Console.WriteLine("5. Edit Contact");
        Console.WriteLine("6. Delete Contact");
        Console.WriteLine("7. Sort Contacts by Name");
        Console.WriteLine("8. Exit");
        Console.Write("Enter your choice: ");
    }

    private void HandleChoice(int choice){
        switch (choice){
            case 1:
                AddressBookUtility.CreateAddressBook();
                break;

            case 2:
                utility = AddressBookUtility.SelectAddressBook();
                break;

            case 3:
                EnsureAddressBookSelected();
                utility.AddContact();
                break;

            case 4:
                EnsureAddressBookSelected();
                utility.AddMultipleContacts();
                break;

            case 5:
                EnsureAddressBookSelected();
                utility.EditContact();
                break;

            case 6:
                EnsureAddressBookSelected();
                utility.DeleteContact();
                break;

            case 7:
                EnsureAddressBookSelected();
                utility.SortContactsByName();
                break;

            case 8:
                Console.WriteLine("Exiting Program...");
                break;

            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }

    private void EnsureAddressBookSelected() {
        if (utility == null)
            throw new Exception("Please select an Address Book first!");
    }
}
