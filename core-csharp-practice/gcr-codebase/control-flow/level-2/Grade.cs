using System;

class Grade{
    static void Main(string[] args){

        //takes input from the user
        Console.Write("Enter the marks in physics: ");
        int physics=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the marks in chemistry: ");
        int chemistry=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the marks in maths: ");
        int maths=Convert.ToInt32(Console.ReadLine());

        double average=(physics+chemistry+maths)/3.0;
        string grade,remarks;

        //grade and remarks distribution 
        if(average>=80){
            grade="A";
            remarks="Level 4, above agency-normalised standards";
        }
        else if(average>=70){
            grade="B";
            remarks="Level 3, at agency-normalized  standards";
        }else if(average>=60){
            grade="C";
            remarks="Level 2, below but approaching standards";
        }else if(average>=50){
            grade="D";
            remarks="Level 1, well below standards.";
        }else if(average>=40){
            grade="E";
            remarks="Too below standards";
        }else{
            grade="R";
            remarks="Remedial standards";
        }

        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);

    }
}