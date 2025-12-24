using System;

class Bonus{
    static void Main(string[] args){

        int n=10;
        //initialising all the arrays 
        double[] salary=new double[n];
        double[] service=new double[n];
        double[] bonus=new double[n];
        double[] finalarray=new double[n];

        double totalbonus=0;
        double totalSalary=0;
        double totalnewSalary=0;

        for(int i=0;i<n;i++){
            Console.Write("Enter the salary of employee " + (i+1) + " ");
            salary[i]=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service of employee " + (i+1) + " ");
            service[i]=Convert.ToDouble(Console.ReadLine());

            if(salary[i]<=0 || service[i]<0){
                Console.WriteLine("Invalid Input,enter again");
                i--;
            }
        }

        for(int i=0;i<n;i++){
            if(service[i]>5){
                bonus[i]=salary[i]*0.05;
            }else{
                bonus[i]=salary[i]*0.02;
            }
            finalarray[i]=salary[i]+bonus[i];

            totalbonus+=bonus[i];
            totalSalary+=salary[i];
            totalnewSalary+=finalarray[i];
        }

        Console.WriteLine("Total Old Salary: " + totalSalary);
        Console.WriteLine("Total Bonus: " + totalbonus);
        Console.WriteLine("Total new Salary: " + totalnewSalary;
        
    }
}