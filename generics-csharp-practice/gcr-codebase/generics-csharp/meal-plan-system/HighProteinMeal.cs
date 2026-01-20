using System;

public class HighProteinMeal : IMealPlan{
    public string Name { get; private set; }
    public int Calories { get; private set; }

    public HighProteinMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }

    public void Display(){
        Console.WriteLine($"[High-Protein] {Name} - {Calories} kcal");
    }
}
