using System;

class BMICalculator{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the weight: ");
        double weight=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height: ");
        double height=Convert.ToDouble(Console.ReadLine());

        //converting cm height to m
        double heightM=height/100;
        //bmi calculation
        double bmi=weight/(heightM*heightM);

        Console.WriteLine("The BMI is: " + bmi);

        //category according to BMI
        if(bmi<=18.4){
            Console.WriteLine("UnderWeight");
        }else if(bmi<=24.9){
            Console.WriteLine("Normal");
        }else if(bmi<=39.9){
            Console.WriteLine("Overweight");
        }else{
            Console.WriteLine("Obese");
        }
    }
}