using System;

class GreatestFactor{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        int factor=1;
        for(int i=num-1;i>=1;i--){
            if(num%i==0){
                factor=i;
                break;
            }
        }
        Console.WriteLine("The Greatest Factor is: "+ factor);
    }
}