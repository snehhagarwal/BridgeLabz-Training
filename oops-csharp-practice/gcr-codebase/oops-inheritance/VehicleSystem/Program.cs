using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] arr=new Vehicle[3];
        arr[0]=new Car {seats=5};
        arr[1]=new Truck{capacity=2000};
        arr[2]=new MotorCycle{sidecar=false};

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].Display();
            Console.WriteLine();
        }
    }
}