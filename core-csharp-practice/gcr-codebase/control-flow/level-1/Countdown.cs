using System;

class CountDown{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the counter value: ");
        int counter=Convert.ToInt32(Console.ReadLine());

        //printing the value of counter and then decrementing the value
        while(counter>=1){
            Console.WriteLine(counter); //printing
            counter--;                  //decrementing
        }
    }
}