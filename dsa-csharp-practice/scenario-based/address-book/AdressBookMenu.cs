using System;

class AddressBookMenu
{
    public void Start()
    {
        IAddressBook utility=new AddressBookUtility();
        int choice;

        do
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Delete Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice");

            choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddContact();
                    break;
                case 2:
                    Console.Write("Enter first Name to Edit: ");
                    string edit=Console.ReadLine();
                    utility.EditContact(edit);
                    break;
                case 3:
                    Console.Write("Enter first name to edit: ");
                    string delete=Console.ReadLine();
                    utility.DeleteContact(delete);
                    break;
                case 4:
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("Invalid Choice: ");
                    break;
            }

        }while(choice!=4);
    }
}