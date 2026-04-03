using System;

class AddTwoNumbers {
    static void Main(string[] args) {
        //read input
        int number1 = int.Parse(Console.ReadLine()); //take number 1
        int number2 = int.Parse(Console.ReadLine()); //take number 2

        //variable to store the sum of numbers
        int c = number1 + number2;
        
        //printing the sum 
        Console.WriteLine("The sum of the two numbers is: " + c);
    }
}