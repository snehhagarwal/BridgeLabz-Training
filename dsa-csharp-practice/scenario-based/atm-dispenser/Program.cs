using System;

class Program
{
    static void Main(string[] args)
    {
        ATM atm;

        Console.WriteLine("Scenario A: Without Rs.500");
        atm=new ScenarioA();
        atm.Dispense(990);

        Console.WriteLine("Scenario B: Without Rs 500");
        atm=new ScenarioB();
        atm.Dispense(550);

        Console.WriteLine("Scenario C: Fallback");
        atm=new ATMLimited();
        atm.Dispense(500);

    }
}
