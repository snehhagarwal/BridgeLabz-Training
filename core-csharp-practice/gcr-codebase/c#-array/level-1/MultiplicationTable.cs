using System;

class MultiplicationTable{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[10];
        
        //table calculation
        for(int i=1;i<=10;i++){
            arr[i-1]=number*i;
        }

        //printing the table
        for(int i=1;i<=10;i++){
            Console.WriteLine(number + " * " + i + " = " + arr[i-1]);
        }
    }
}