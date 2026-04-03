using System;
using System.Data.Common;

// Represents a node in the ticket reservation linked list
class TicketNode
{
    public int Id;
    public string Name;
    public TicketNode next;
}

class TickeSystem
{
    TicketNode head; // Head of the circular linked list
    
    // Adds a new ticket to the circular linked list
    public void Add(int id,string name)
    {
        TicketNode node=new TicketNode{Id=id,Name=name};
        if (head == null)
        {
            head=node;
            node.next=head; // Point to itself for circular list
            return;
        }
        TicketNode temp=head;
        while (temp.next != head) // Traverse to the last node
        {
            temp=temp.next;
        }
        temp.next=node;
        node.next=head; // Complete the circle
    }

    // Displays all tickets in the list
    public void Display()
    {
        if (head == null)
        {
            return; // Nothing to display
        }
        TicketNode temp=head;
        do
        {
            Console.WriteLine(temp.Id + " " + temp.Name);
            temp=temp.next;
        }while(temp!=head); // Loop until back to head
    }
}

// Main class to test the ticket system
class TicketMain
{
    // Entry point for the program
    static void Main(string[] args)
    {
        TickeSystem ts=new TickeSystem();
        ts.Add(101,"Ram");
        ts.Add(102,"Siya");
        ts.Display();
    }
}
