using System;

// Represents a process node in the circular linked list
class ProcessNode
{
    // Process ID and burst time
    public int Id,Burst;
    // Pointer to next node
    public ProcessNode next;
}

// Implements Round Robin scheduling using a circular linked list
class RoundRobin
{
    // Head of the circular linked list
    ProcessNode head;

    // Adds a new process to the list
    public void Add(int id,int burst)
    {
        ProcessNode node=new ProcessNode{Id=id,Burst=burst};
        if (head == null)
        {
            head=node;
            node.next=head;
            return;
        }

        ProcessNode temp=head;
        while (temp.next != head)
        {
            temp=temp.next;
        }
        temp.next=node;
        node.next=head;
    }

    // Displays all processes in the list
    public void Display()
    {
        if (head == null)
        {
            return;
        }
        ProcessNode temp=head;
        do
        {
            Console.WriteLine(temp.Id + " BT:- " + temp.Burst);
            temp=temp.next;
        }while(temp!=head);
    }
}

// Main class for running the Round Robin example
class RRMain
{
    // Entry point to demonstrate Round Robin scheduling
    static void Main(string[] args)
    {
        RoundRobin rr=new RoundRobin();
        rr.Add(1,5);
        rr.Add(2,3);
        rr.Display();
    }
}
