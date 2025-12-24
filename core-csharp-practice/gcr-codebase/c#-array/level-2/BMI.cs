using System;

class BMI{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the number of persons: ");
        int n=Convert.ToInt32(Console.ReadLine());

        //initialising all the arrays
        double[] weight=new double[n];
        double[] height=new double[n];
        double[] bmi=new double[n];
        string[] status=new string[n];


        //bmi calculation and storing in array 
        for(int i=0;i<n;i++){
            Console.Write("Enter the weight: ");
            weight[i]=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            height[i]=Convert.ToDouble(Console.ReadLine());

            bmi[i]=weight[i]/(height[i] * height[i]);

            //updating the status 
            if(bmi[i]<=18.4){
                status[i]="Underweight";
            }else if(bmi[i]<=24.9){
                status[i]="Normal";
            }else if(bmi[i]<=39.9){
                status[i]="Overweight";
            }else{
                status[i]="Obese";
            }
        }

        //printing statement 
        for(int i=0;i<n;i++){
            Console.WriteLine("BMI: " + bmi[i] + " Status: " + status[i]);
        }
    }
}