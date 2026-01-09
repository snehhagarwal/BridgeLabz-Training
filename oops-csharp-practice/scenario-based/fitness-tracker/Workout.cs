using System;

class Workout
{
    protected string workoutName;  //workout name
    protected int duration;        //time in minutes

    //constructor
    public Workout(string name,int time)
    {
        workoutName=name;
        duration=time;
    }
}