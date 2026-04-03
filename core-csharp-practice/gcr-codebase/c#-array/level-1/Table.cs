using System;

class Table{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Emter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[4];
         
        //storing the array
        for(int i=6;i<=9;i++){
            arr[i-6]=number*i;
        }
 
        //printing the array
        for(int i=6;i<=9;i++){
            Console.WriteLine(number + " * " + i + " = " + arr[i-6]);
        }
    }
}