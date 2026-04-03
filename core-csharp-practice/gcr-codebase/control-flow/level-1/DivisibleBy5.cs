using System;

class DivisibleBy5{
    static void Main(string[] args){
        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        //checking divisiblity by 5 
        if(number%5==0){
            Console.WriteLine("Is the number " + number + " divisible by 5? Yes");
        }else{
            Console.WriteLine("Is the number " + number + " divisible by 5? No");
        }
    }
}