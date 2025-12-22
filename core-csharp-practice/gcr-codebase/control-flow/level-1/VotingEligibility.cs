using System;

class VotingEligiblity{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the age of the person: ");
        int age=Convert.ToInt32(Console.ReadLine());
        
        //checking whether the age is greater than or equal to 18
        if(age>=18){
            Console.ReadLine("The person's age is " + age + " and can vote.");
        }
        else{
            Console.WriteLine("The person's age is " + age + " and cannot vote.")
        }
    }
}