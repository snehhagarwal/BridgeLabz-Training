using System;

class LargestAndSecondLargestDynamic{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int maxDigit=10;
        int[] digit=new int[maxDigit];
        int idx=0;

        //code for forming array
        while(number!=0){
            if(idx==maxDigit){
                maxDigit+=10;
                int[] temp=new int[maxDigit];
                for(int i=0;i<digit.Length;i++){
                    temp[i]=digit[i];
                }
                digit=temp;
            }
            digit[idx]=number%10;
            idx++;
            number=number/10;
        }

        //finding the largest and second largest
        int largest=0;
        int secondLargest=0;
        for(int i=0;i<idx;i++){
            if(digit[i]>largest){
                secondLargest=largest;
                largest=digit[i];
            }else if(digit[i]>secondLargest && digit[i]!=largest){
                secondLargest=digit[i];
            }
        }

        //printing statement
        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + secondLargest);

    }
}