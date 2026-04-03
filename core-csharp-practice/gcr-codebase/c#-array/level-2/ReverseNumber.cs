using System;

class ReverseNumber{
    static void Main(string[] args){
        
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        int temp=num;
        int count=0;
 
        //counting the length of the number
        while(temp!=0){
            count++;
            temp=temp/10;
        }

        int[] digit=new int[count];

        //reversing the number
        for(int i=0;i<count;i++){
            digit[i]=num%10;
            num=num/10;
        }
         
        //printing the reversed number
        Console.Write("Reversed Number: ");
        for(int i=0;i<count;i++){
            Console.Write(digit[i]);
        }
    } 
}