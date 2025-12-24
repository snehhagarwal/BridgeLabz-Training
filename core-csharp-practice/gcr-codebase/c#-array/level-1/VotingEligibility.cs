using System;

class VotingEligibility{
    static void Main(string[] args){

        //taking input from the user
        int[] arr=new int[10];

        for(int i=0;i<arr.Length;i++){
            Console.Write("Enter the age of student: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        //checking if student is eligible to vote
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<0){
                Console.WriteLine("Invalid Age");
            }else if(arr[i]>=18){
                Console.WriteLine("The student with age " + arr[i] + " can vote.");
            }else{
                Console.WriteLine("The student with age " + arr[i] + " cannot vote.");
            }
        }
    }
}