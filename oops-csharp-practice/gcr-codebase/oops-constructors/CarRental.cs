using System;

class Car
{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;

    public Car(string name,string model,string days)
    {
        this.CustomerName=name;
        this.CarModel=model;
        this.RentalDays=days;
    }

    public void Calculate()
    {
        int cost=1000;
        Console.WriteLine("Total Cost: " + (RentalDays*cost));
    }
}

class CarRental
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the customer name: ");
        string name=Console.ReadLine();

        Console.Write("Enter the car model: ");
        string model=Console.ReadLine();

        Console.Write("Enter the rental days: ");
        int days=Convert.ToInt32(Console.ReadLine());

        Car c=new Car(name,model,days);
        c.Calculate();
    }
}