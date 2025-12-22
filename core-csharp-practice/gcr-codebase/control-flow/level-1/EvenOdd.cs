using System;

class EvenOdd{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //checking natural number
        if(num>0){
            for(int i=1;i<=num;i++){
                //checking if even or odd
                if(i%2==0){
                    Console.WriteLine("The number " + i + " is Even.");
                }else{
                    Console.WriteLine("The number " + i + " is Odd");
                }
            }
        }
    }
}