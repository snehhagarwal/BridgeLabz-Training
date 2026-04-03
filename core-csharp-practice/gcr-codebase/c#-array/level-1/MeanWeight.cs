using System;

class MeanWeight{
    static void Main(string[] args){

        double[] arr=new double[11];
        double sum=0;

        //take height as input from user
        for(int i=0;i<arr.Length;i++){
            Console.Write("Enter the height of player: ");
            arr[i]=Convert.ToDouble(Console.ReadLine());

            sum+=arr[i];
        }

        //mean calculation
        double mean=sum/11;
        Console.WriteLine("Mean Height: " + mean);
    }
}