class BrowserMenu
{
    private BrowserUtility utility = new BrowserUtility();
    private int choice;

    public void Start()
    {
        do
        {
            Console.WriteLine("BrowserBuddy Menu");
            Console.WriteLine("1. Visit Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Tab");
            Console.WriteLine("6. Show Current Page");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter URL: ");
                    utility.Visit(Console.ReadLine());
                    break;

                case 2:
                    utility.Back();
                    break;

                case 3:
                    utility.Forward();
                    break;

                case 4:
                    utility.CloseTab();
                    break;

                case 5:
                    utility.RestoreTab();
                    break;

                case 6:
                    utility.ShowCurrentPage();
                    break;

                case 7:
                    Console.WriteLine("Exiting BrowserBuddy...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 7);
    }
}
