using System;

class YoungestAndTallest{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the Amar's age and height: ");
        int amarAge=Convert.ToInt32(Console.ReadLine());
        int amarHeight=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Akbar's age and height: ");
        int akbarAge=Convert.ToInt32(Console.ReadLine());
        int akbarHeight=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Anthony's age and height: ");
        int anthonyAge=Convert.ToInt32(Console.ReadLine());
        int anthonyHeight=Convert.ToInt32(Console.ReadLine());

        //getting the youngest age
        int youngest;
        if(amarAge<akbarAge && amarAge<anthonyAge){
            youngest=amarAge;
        }else if(akbarAge<amarAge && akbarAge<anthonyAge){
            youngest=akbarAge;
        }else{
            youngest=anthonyAge;
        }
         
        //getting the tallest height
        int tallest;
        if(amarHeight>akbarHeight && amarHeight>anthonyHeight){
            tallest=amarHeight;
        }else if(akbarHeight>amarHeight && akbarHeight>anthonyHeight){
            tallest=akbarHeight;
        }else{
            tallest=anthonyHeight;
        }

        Console.WriteLine("The youngest age amongst them is: " + youngest);
        Console.WriteLine("The tallest height amongst them is: " + tallest);
    }
}