using System.Collections.Generic;

public class Meal<T> where T : IMealPlan
{
    private List<T> meals = new List<T>();

    public void AddMeal(T meal)
    {
        meals.Add(meal);
    }

    public void DisplayMeals()
    {
        foreach (var meal in meals)
            meal.Display();
    }

    public T GetMealByName(string name)
    {
        return meals.Find(m => m.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
    }

    public List<T> GetAllMeals()
    {
        return meals;
    }
}
