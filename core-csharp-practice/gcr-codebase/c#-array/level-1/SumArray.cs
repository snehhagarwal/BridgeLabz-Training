using System;

class SumArray{
    static void Main(string[] args){

        double[] arr=new double[10];
        double total=0.0;
        int idx=0;

        while(true){
            Console.Write("Enter the number: ");
            double val=Convert.ToDouble(Console.ReadLine());

            //checking negative or 10 as input
            if(val<=0 || idx==10){
                break;
            }

            //storing value in array
            arr[idx]=val;
            idx++;
        }

        //sum of all elements in array
        for(int i=0;i<idx;i++){
            total+=arr[i];
        }

        Console.WriteLine("The sum is: " + total);
    }
}