using System;

class AvgPercentage{
    static void Main(string[] args){
        //marks in maths
        int maths=94;

        //marks in physics
        int physics=95;

        //marks in chemistry
        int chemistry=96;

        //avg percentage marks
        double avg=(maths+physics+chemistry)/3.0;

        Console.WriteLine("Sam's avg mark in PCM is " + avg);
    }
}