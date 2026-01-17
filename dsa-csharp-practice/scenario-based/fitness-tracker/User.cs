// encapsulated class
 
class User{
    // attributes of the user 
    private string name;
    private int steps;
    
    // constructor of the user 
    
    public User(string name, int steps){
        this.name = name;
        this.steps = steps;
    }
    
    // method to calculate the number of steps of a user 
    public int GetSteps(){
        return steps;
    }
    
    // method to display the user with their steps 
    public void Display(){
        Console.WriteLine(name + " - " + steps + " steps");
    }
}
