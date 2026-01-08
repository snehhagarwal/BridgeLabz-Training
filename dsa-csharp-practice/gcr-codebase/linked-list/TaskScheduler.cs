using System;

// Represents a node in the task linked list
class TaskNode
{
    public int Id;
    public string Name;
    public int Priority;
    public TaskNode next;
}

// Manages the circular linked list of tasks
class TaskScheduler
{
    TaskNode head;

    // Adds a new task to the circular list
    public void AddTask(int id,string name,int priority)
    {
        TaskNode node=new TaskNode{Id=id,Name=name,Priority=priority};

        if (head == null)
        {
            head=node;
            node.next=head;
            return;
        }

        TaskNode temp=head;
        while (temp.next != head)
        {
            temp=temp.next;
        }
        temp.next=node;
        node.next=head;
    }

    // Displays all tasks in the list
    public void Display()
    {
        if (head == null)
        {
            return;
        }
        TaskNode temp=head;
        do
        {
            Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Priority);
            temp=temp.next;
        }while(temp!=head);
    }
}

// Main class for demonstrating task scheduler operations
class TaskMain
{
    static void Main(string[] args)
    {
        TaskScheduler ts=new TaskScheduler();
        ts.AddTask(1,"Coding",1);
        ts.AddTask(2,"Testing",2);
        ts.Display();
    }
}
