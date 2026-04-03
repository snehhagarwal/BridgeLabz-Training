using System;
using System.Collections.Generic;

public class RankManager
{
    // Student list
    private List<Student> students = new List<Student>();

    // Add student
    public void AddStudent()
    {
        Console.Write("Enter Roll No: ");
        int roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        // Store student
        students.Add(new Student(roll, name, marks));
        Console.WriteLine("Student added successfully!\n");
    }

    // Generate ranks
    public void GenerateRankList()
    {
        // Check empty list
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.\n");
            return;
        }

        // Sort by marks
        students = MergeSorter.MergeSort(students);

        Console.WriteLine("\n--- STATE WISE RANK LIST ---");

        int rank = 1;

        // Display ranks
        foreach (var s in students)
        {
            Console.WriteLine($"Rank {rank++} | Roll: {s.RollNo} | Name: {s.Name} | Marks: {s.Marks}");
        }

        Console.WriteLine();
    }
}
