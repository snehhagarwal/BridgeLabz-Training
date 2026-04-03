using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;

    //parameterized constructor
    public Student(int num,string name,double cgpa)
    {
        this.rollNumber=num;
        this.name=name;
        this.CGPA=cgpa;
    }

    //public methods for cgpa
    public double GetCGPA()
    {
        return CGPA;
    }

    public void SetCgpa(double cgpa)
    {
        CGPA=cgpa;
    }
}

class PostGraduate : Student
{
    public PostGraduate(int rollNumber,string name,double cgpa)
    {
        this.rollNumber=rollNumber;
        this.name=name;
        SetCgpa(cgpa);
    }

    public void Display()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name of the Student: " + name);
        Console.WriteLine("The CGPA is: " + GetCGPA());
    }
}

class UniversityManagement
{
    static void Main(string[] args)
    {
        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter CGPA: ");
        double cgpa = Convert.ToDouble(Console.ReadLine());

        PostgraduateStudent pg = new PostgraduateStudent(roll, name, cgpa);
        pg.Display();
    }
}
