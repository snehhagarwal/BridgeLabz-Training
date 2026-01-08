using System;

class Program
{
    static void Main(string[] args)
    {
        Appliance[] appliance=new Appliance[3];
        appliance[0]=new Light("Bathroom");
        appliance[1]=new Fan("Bedroom");
        appliance[2]=new AC("Hall");

        for(int i = 0; i < appliance.Length; i++)
        {
            appliance[i].TurnOn();
            appliance[i].TurnOff();
            Console.WriteLine();
        }
    }
}