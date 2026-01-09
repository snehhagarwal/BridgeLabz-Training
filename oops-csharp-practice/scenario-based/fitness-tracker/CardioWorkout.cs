using System;

class CardioWorkout : Workout, ITrackable
{
    public CardioWorkout(string name,int time)
    {
        workoutName=name;
        duration=time;
    }

    //tracking the cardio workout
    public void Track()
    {
        Console.WriteLine("Cardio Workout: " + workoutName);
        Console.WriteLine("Duration: " + duration + " minutes");
    }
}