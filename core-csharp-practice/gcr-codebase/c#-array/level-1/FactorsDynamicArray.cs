using System;

class FactorsDynamicArray{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        //initialising maxFactor to 10
        int maxFactor=10;
        int[] arr=new int[maxFactor];
        int idx=0;

        //loop for factors
        for(int i=1;i<=number;i++){
            if(number%i==0){
                if(idx==maxFactor){
                    maxFactor=maxFactor*2;
                    int[] arr1=new int[maxFactor];
                    for(int j=0;j<arr1.Length;j++){
                        arr1[j]=arr[j];
                    }
                    arr=arr1;
                }
                arr[idx]=i;
                idx++;
            }
        }

        //printing the factors
        Console.WriteLine("Factors: ");
        for(int i=0;i<idx;i++){
            Console.Write(arr[i] + " ");
        }
        
    }
}