using System;

class OddEvenArray{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        //negative number
        if(number<=0){
            Console.WriteLine("Invalid Number");
        }

        //odd array and even array
        int[] even=new int[number/2];
        int[] odd=new int[number/2+1];
        
        //indexes for both the array
        int evenidx=0;
        int oddidx=0;

        //segregating the numbers in both arrays
        for(int i=1;i<=number;i++){
            if(i%2==0){
                even[evenidx]=i;
                evenidx++;
            }
            else{
                odd[oddidx]=i;
                oddidx++;
            }
        }

        //printing odd numbers
        Console.WriteLine("Odd Numbers: ");
        for(int i=0;i<odd.Length;i++){
            Console.Write(odd[i] + " ");
        }

        //printing even numbers
        Console.WriteLine("\n Even Numbers: ");
        for(int i=0;i<even.Length;i++){
            Console.Write(even[i] + " ");
        }

    }
}