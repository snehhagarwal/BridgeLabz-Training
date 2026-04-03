using System;

// Represents a node in the task linked list
class TaskNode
{
    public int Id;
    public string Name;
    public int Priority;
    public string DueDate;
    public TaskNode next;
}

// Manages the circular linked list of tasks
class TaskScheduler
{
    TaskNode head;

    // Adds a new task to the circular list
    public void AddTask(int id, string name, int priority, string dueDate)
    {
        TaskNode node = new TaskNode
        {
            Id = id,
            Name = name,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.next != head)
            temp = temp.next;

        temp.next = node;
        node.next = head;
    }

    //add task at specicfic position
    public void AddAtPosition(int pos, int id, string name, int priority, string dueDate)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode temp = head;
        for (int i = 1; i < pos - 1 && temp.next != head; i++)
            temp = temp.next;

        TaskNode node = new TaskNode
        {
            Id = id,
            Name = name,
            Priority = priority,
            DueDate = dueDate,
            next = temp.next
        };

        temp.next = node;
    }

    //add task at the beginning
    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode node = new TaskNode { Id = id, Name = name, Priority = priority, DueDate = dueDate };

        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }

        TaskNode temp = head;
        while (temp.next != head)
            temp = temp.next;

        node.next = head;
        temp.next = node;
        head = node;
    }


    // Displays all tasks in the list
    public void Display()
    {
        if (head == null)
        {
            return;
        }
        TaskNode temp = head;
        do
        {
            Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Priority + " " + temp.DueDate);
            temp = temp.next;
        } while (temp != head);
    }

    //removing task by id
    public void RemoveById(int id)
    {
        if (head == null) return;

        if (head.Id == id)
        {
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = head.next;
            head = head.next;
            return;
        }

        TaskNode curr = head;
        while (curr.next != head && curr.next.Id != id)
            curr = curr.next;

        if (curr.next != head)
            curr.next = curr.next.next;
    }


    //viewing current task and move to next 
    public void ViewCurrent()
    {
        if (head != null)
            Console.WriteLine(head.Id + " " + head.Name);
    }

    public void MoveNext()
    {
        if (head != null)
            head = head.next;
    }


    //search by priority 
    public void SearchByPriority(int priority)
    {
        if (head == null) return;

        TaskNode temp = head;
        do
        {
            if (temp.Priority == priority)
                Console.WriteLine(temp.Id + " " + temp.Name);
            temp = temp.next;
        } while (temp != head);
    }

}

// Main class for demonstrating task scheduler operations
class TaskMain
{
    static void Main(string[] args)
    {
        TaskScheduler ts = new TaskScheduler();

        // Add tasks
        ts.AddTask(1, "Coding", 1, "10-01-2026");
        ts.AddTask(2, "Testing", 2, "12-01-2026");

        // Add at beginning
        ts.AddAtBeginning(0, "Design", 1, "08-01-2026");

        // Add at specific position
        ts.AddAtPosition(2, 3, "Debugging", 2, "11-01-2026");

        Console.WriteLine("\nAll Tasks:");
        ts.Display();

        // View current task
        Console.WriteLine("\nCurrent Task:");
        ts.ViewCurrent();

        // Move to next task
        ts.MoveNext();
        Console.WriteLine("\nAfter Moving to Next Task:");
        ts.ViewCurrent();

        // Search by priority
        Console.WriteLine("\nTasks with Priority 2:");
        ts.SearchByPriority(2);

        // Remove task
        ts.RemoveById(3);
        Console.WriteLine("\nAfter Removing Task ID 3:");
        ts.Display();
    }
}

