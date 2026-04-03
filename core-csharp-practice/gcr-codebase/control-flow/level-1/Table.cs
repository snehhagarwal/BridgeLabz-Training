using System;

class Table{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //table printing
        for(int i=6;i<=9;i++){
            Console.WriteLine(num + " * " + i + " = " + (num*i));
        }
    }
}