using System;

// Represents a node in the student linked list
class StudentNode
{
    public int Roll;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode next;
}

// Manages the linked list of students
class StudentList
{
    StudentNode head;

    // Adds a new student at the start of the list
    public void AddAtBeginning(int roll, string name, int age, string grade)
{
    StudentNode node = new StudentNode
    {
        Roll = roll,
        Name = name,
        Age = age,
        Grade = grade,
        next = head
    };
    head = node;
}

    // Adds a new student at the end of the list
    public void AddAtEnd(int roll,string name,int age,string grade)
    {
        StudentNode node=new StudentNode{Roll=roll,Name=name,Age=age,Grade=grade};
        if (head == null)
        {
            head=node;
            return;
        }

        StudentNode temp=head;
        while (temp.next != null)
        {
            temp=temp.next;
        }
        temp.next=node;
    }

    // Adds a new student at the specified position
    public void AddAtPosition(int pos, int roll, string name, int age, string grade)
{
    if (pos == 1)
    {
        AddAtBeginning(roll, name, age, grade);
        return;
    }

    StudentNode temp = head;
    for (int i = 1; i < pos - 1 && temp != null; i++)
    {
        temp = temp.next;
    }

    if (temp == null)
    {
        Console.WriteLine("Invalid position");
        return;
    }

    StudentNode node = new StudentNode
    {
        Roll = roll,
        Name = name,
        Age = age,
        Grade = grade,
        next = temp.next
    };
    temp.next = node;
}


    // Deletes a student by roll number
    public void DeleteByRoll(int roll)
    {
        if (head == null)
        {
            return;
        }
        if (head.Roll == roll)
        {
            head=head.next;
            return;
        }

        StudentNode temp=head;
        while(temp.next!=null && temp.next.Roll != roll)
        {
            temp=temp.next;
        }

        if (temp.next != null)
        {
            temp.next=temp.next.next;
        }
    }

    // Searches for a student by roll number
    public void Search(int roll)
    {
        StudentNode temp=head;
        while (temp != null)
        {
            if (temp.Roll == roll)
            {
                Console.WriteLine("Found: " + temp.Name + " ,Grade: " + temp.Grade);
                return;
            }
            temp=temp.next;
        }

        Console.WriteLine("Student not found");
    }

    // Updates the grade of a student by roll number
    public void UpdateGrade(int roll,string grade)
    {
        StudentNode temp=head;
        while (temp != null)
        {
            if (temp.Roll == roll)
            {
                temp.Grade=grade;
                return;
            }
            temp=temp.next;
        }
    }

    // Displays all students in the list
    public void Display()
    {
        StudentNode temp=head;
        while (temp != null)
        {
            Console.WriteLine(temp.Roll +" " + temp.Name + " " + temp.Age + " " + temp.Grade);
            temp=temp.next;
        }
    }
}

// Main class for demonstrating student list operations
class StudentMain
{
    static void Main(string[] args)
    {
        StudentList list=new StudentList();
        list.AddAtEnd(1,"Ram",19,"A");
        list.AddAtEnd(2,"Siya",20,"B");
        list.Display();
        list.UpdateGrade(2,"A+");
        list.Search(2);
    }
}