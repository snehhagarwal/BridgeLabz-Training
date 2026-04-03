using System;

class StrengthWorkout : Workout, ITrackable
{
    //parameterized constructor
    public StrengthWorkout(string name,int time)
    {
        workoutName=name;
        duration=time;
    }

    //track strength workout
    public void Track()
    {
        Console.WriteLine("Strength Workout: " + workoutName);
        Console.WriteLine("Duration: " + duration + " minutes");
    }
}
