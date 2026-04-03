using System;

class CountdownForLoop{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //printing the number and decrementing until it reaches 1
        for(int i=num;i>=0;i--){
            Console.WriteLine(i);
        }
    }
}