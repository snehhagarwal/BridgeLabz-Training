using System;

class Program
{
    static void Main(string[] args)
    {
        //create user
        UserProfile user=new UserProfile("Ram");
        user.ShowUser();

        //creating workouts using objects
        ITrackable cardio=new CardioWorkout("Running" ,30);
        ITrackable strength=new StrengthWorkout("Push Ups",45);

        Console.WriteLine();

        //tracking the workouts which we have created
        cardio.Track();
        Console.WriteLine();
        strength.Track();

    }
}