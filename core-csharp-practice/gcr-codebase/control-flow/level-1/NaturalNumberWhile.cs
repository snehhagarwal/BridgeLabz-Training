using System;

class NaturalNumberWhile{
    static void Main(string[] args){

        //taking input from user
        Console.Write("Enter the value: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //if number is natural number
        if(num>=0){
            int sum=0;
            int i=0;
            //sum using while
            while(i<=num){
                sum+=i;
                i++;
            }
            //sum using formula
            int sumformula=n*(n+1)/2;
            //compare
            Console.WriteLine(sum==sumformula);
        }else{
            Console.WriteLine("The number is not natural number");
        }
    }
}