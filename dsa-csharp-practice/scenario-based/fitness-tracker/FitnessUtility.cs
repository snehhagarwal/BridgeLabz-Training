// Utility class implements interface
class FitnessUtility : IFitnessTracker{
    // array of users of size 20
    private User[] users = new User[20];
    private int count = 0;

    //method to add a new user 
    public void AddUser(){
        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        Console.Write("Enter steps: ");
        int steps = int.Parse(Console.ReadLine());

        users[count++] = new User(name, steps);
        Console.WriteLine("User data added.");
    }

    // method to sort the users by number of steps 
    public void SortBySteps(){
        // Bubble Sort (Descending order)
        for (int i = 0; i < count - 1; i++){
            for (int j = 0; j < count - i - 1; j++){
                if (users[j].GetSteps() < users[j + 1].GetSteps()){
                    User temp = users[j];
                    users[j] = users[j + 1];
                    users[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Leaderboard updated using Bubble Sort.");
    }
    
    // method to display the leaderboard
    public void DisplayLeaderboard(){
        if (count == 0){
            Console.WriteLine("No users found.");
            return;
        }
        Console.WriteLine("\n--- Daily Step Leaderboard ---");
        for (int i = 0; i < count; i++){
            users[i].Display();
        }
    }
}
