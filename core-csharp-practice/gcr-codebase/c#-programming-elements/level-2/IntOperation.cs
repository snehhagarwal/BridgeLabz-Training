using System;

class IntOperation{
    static void Main(){
        //input three numbers from user
        Console.WriteLine("Enter 1st number");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number");
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 3rd number");
        int c=Convert.ToInt32(Console.ReadLine());

        //operations
        int r1=a+b*c;
        int r2=a*b+c;
        int r3=c+a/b;
        int r4=a%b+c;

        Console.WriteLine("The results of Int Operations are " + r1 + ", " + r2 + ", " + r3 + " and " + r4);
    }
}