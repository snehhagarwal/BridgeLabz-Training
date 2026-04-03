class Program{
    public static void Main(string[] args){
        // interface reference 
        IFitnessTracker utility = new FitnessUtility();
        FitnessMenu menu = new FitnessMenu(utility);
        // display the main menu
        menu.ShowMenu();
    }
}
