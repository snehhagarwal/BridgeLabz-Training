using System;

class NaturalNumberFor{
    static void Main(string[] args){

        //take input from the user
        Console.WriteLine("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
         
        //checking if the number is natural number
        if(num>0){
            int sum=0;
            for(int i=0;i<=num;i++){
                sum+=i;
            }
            int sumformula=n*(n+1)/2;
            Console.WriteLine(sum==sumformula);
        }else{
            Console.WriteLine("The number is not natural number");
        }
    }
}