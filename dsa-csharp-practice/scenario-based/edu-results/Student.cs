using System;

public class Student
{
    // Roll number
    public int RollNo { get; set; }

    // Student name
    public string Name { get; set; }

    // Marks obtained
    public int Marks { get; set; }

    // Constructor
    public Student(int rollNo, string name, int marks)
    {
        RollNo = rollNo;
        Name = name;
        Marks = marks;
    }
}
