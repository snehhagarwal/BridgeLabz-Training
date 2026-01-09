using System;

// Represents a process node in the circular linked list
class ProcessNode
{
    public int Id,Burst;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnAroundTime;
    // Pointer to next node
    public ProcessNode next;
}

// Implements Round Robin scheduling using a circular linked list
class RoundRobin
{
    // Head of the circular linked list
    ProcessNode head;

    // Adds a new process to the list
    public void Add(int id,int burst,int priority)
    {
        ProcessNode node=new ProcessNode{Id=id,Burst=burst,RemainingTime=burst,Priority=priority};
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

    //Remove process by ID
    private void RemoveProcess(int id)
    {
        if (head == null)
        {
            return;
        }

        if(head.Id==id && head.next == head)
        {
            head=null;
            return;
        }

        if (head.Id == id)
        {
            ProcessNode temp=head;
            while (temp.next != head)
            {
                temp=temp.next;
            }
            temp.next=head.next;
            head=head.next;
            return;
        }

        ProcessNode curr=head;
        while(curr.next!=head && curr.next.Id != id)
        {
            curr=curr.next;
        }

        if (curr.next.Id == id)
        {
            curr.next=curr.next.next;
        }
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
            Console.WriteLine(temp.Id + " BT:- " + temp.Burst + " Remaining: " + temp.RemainingTime);
            temp=temp.next;
        }while(temp!=head);
    }

    public void Schedule(int timeQuantum)
    {
        int time=0;
        int completed=0;
        int totalWaiting=0;
        int totalTurnAround=0;

        ProcessNode curr=head;

        while (head != null)
        {
            if (curr.RemainingTime > 0)
            {
                Console.WriteLine("Executing Process: " + curr.Id);
                if (curr.RemainingTime > timeQuantum)
                {
                    curr.RemainingTime-=timeQuantum;
                    time+=timeQuantum;
                }
                else
                {
                    time+=curr.RemainingTime;
                    curr.RemainingTime=0;
                    curr.TurnAroundTime=time;
                    curr.WaitingTime=curr.TurnAroundTime-curr.Burst;
                    totalWaiting+=curr.WaitingTime;
                    totalTurnAround+=curr.TurnAroundTime;
                    completed++;

                    int completedId=curr.Id;
                    curr=curr.next;
                    RemoveProcess(completedId);

                    Display();
                    continue;
                }
            }
            curr=curr.next;
            Display();
        }

        Console.WriteLine("Average Waiing Time: " + (double)totalWaiting/completed);
        
        Console.WriteLine("Average TurnAround Time: " + (double)totalTurnAround/completed);
    }
}

// Main class for running the Round Robin example
class RRMain
{
    // Entry point to demonstrate Round Robin scheduling
    static void Main(string[] args)
    {
        RoundRobin rr=new RoundRobin();
        rr.Add(1,5,1);
        rr.Add(2,3,2);
        rr.Add(3,8,1);
        
        int timeQuantum=2;

        Console.WriteLine("Initial Process: ");
        rr.Display();

        Console.WriteLine("Round Robin Scheduling: ");
        rr.Schedule(timeQuantum);
    }
}
