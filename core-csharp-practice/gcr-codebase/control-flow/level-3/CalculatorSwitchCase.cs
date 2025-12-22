using System;

class CalculatorSwitchCase{
    static void Main(string[] args){

        //take numbers and operator as input from the user
        Console.Write("Enter the first number: ");
        double num1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2=Convert.ToDouble(Console.ReadLine());

        string op=Console.ReadLine();

        //switch case for operations 
        switch(op){
            case "+":
                Console.WriteLine("The addition operation results: " + (num1+num2));
                break;
            case "-":
                Console.WriteLine("The subtraction operation results: " + (num1-num2));
                break;
            case "*":
                Console.WriteLine("The multiplication operation results: " + (num1*num2));
                break;
            case "/":
                if(num2!=0){
                   Console.WriteLine("The division operation results: " + (num1/num2));     
                }
                else{
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}