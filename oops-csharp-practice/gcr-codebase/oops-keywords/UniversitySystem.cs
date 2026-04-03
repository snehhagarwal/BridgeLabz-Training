using System;
class Student
{
    public static string UniversityName="National University"; // static university name
    private static int totalStudent=0; // static student count
    public readonly int rollNumber; // read-only roll number
    public string Name; // student name
    public string Grade; // student grade

    public Student(string name,int num,string grade)
    {
        this.Name=name; // set name
        this.rollNumber=num; // set roll number
        this.Grade=grade; // set grade
        totalStudent++; // increment count
    }

    public static void DisplayStudent()
    {
        Console.WriteLine("Total Students: " + totalStudent);
    }

    public void Display()
    {
        if(this is Student) // type check (redundant)
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Grade: " + Grade);

        }
        else
        {
            Console.WriteLine("Not a valid Student");
        }
    }
}

class UniversitySystem
{
    static void Main(string[] args)
    {
        Student s1=new Student("Khushi",101,"A"); // create student 1
        Student s2=new Student("Ashita",102,"B"); // create student 2

        s1.Display(); // show student 1
        s2.Display(); // show student 2

        Student.DisplayStudent(); // show total students
    }
}