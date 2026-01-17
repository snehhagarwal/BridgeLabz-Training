// main menu 
class FitnessMenu{
    private IFitnessTracker tracker;

    public FitnessMenu(IFitnessTracker tracker){
        this.tracker = tracker;
    }

    public void ShowMenu() {
        int choice;
        do{
            Console.WriteLine("\n1. Add User Steps");
            Console.WriteLine("2. Update Leaderboard");
            Console.WriteLine("3. Display Leaderboard");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    tracker.AddUser();
                    break;
                case 2:
                    tracker.SortBySteps();
                    break;
                case 3:
                    tracker.DisplayLeaderboard();
                    break;
                case 4:
                    Console.WriteLine("Exiting Fitness Tracker...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}
