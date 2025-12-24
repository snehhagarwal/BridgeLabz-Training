using System;

class PositiveNegativeOrZero{
      static void Main(string[] args){

        //an array of 5 elements
        int[] arr=new int[5];

        //taking input from user
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
         
         //code to check positive,negative and zero
        for(int i=0;i<arr.Length;i++){
              if(arr[i]>0){
                if(arr[i]%2==0){
                    Console.WriteLine("The number " + arr[i] + " is Positive Even");
                }else{
                    Console.WriteLine("The number " + arr[i] + " is Positive Odd");
                }
              }else if(arr[i]<0){
                Console.WriteLine(arr[i] + " is Negative");
              }else{
                Console.WriteLine("The number is Zero");
              }
        }
     
        //comparing
        if(arr[0]==arr[4]){
            Console.WriteLine("First and Last elements are equal");
        }else if(arr[0]>arr[4]){
            Console.WriteLine("First element is Greater");
        }else{
            Console.WriteLine("Last element is Greater");
        }

      }
}