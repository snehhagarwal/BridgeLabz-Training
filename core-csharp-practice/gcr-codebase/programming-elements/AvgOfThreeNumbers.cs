using System;

class AvgOfThreeNumbers {
    static void Main(string[] args) {
        //read input
        Console.WriteLine("Enter the first number: ");
        int n1 = int.Parse(Console.ReadLine()); //take number 1 as input

        Console.WriteLine("Enter the second number: ");
        int n2 = int.Parse(Console.ReadLine()); //take number 2 as input

        Console.WriteLine("Enter the thirs number: ");
        int n3 = int.Parse(Console.ReadLine()); //take number 3 as input

        //calculate the average
        int average = (n1 + n2 + n3) / 3;

        //printing the avg
        Console.WriteLine("The average of three numbers is: " + average);
        
    }
}