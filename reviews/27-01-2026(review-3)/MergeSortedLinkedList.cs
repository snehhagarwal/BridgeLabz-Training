//question Merge Two Sorted Linked List without using third linked list

using System;
public class Node
{
    public int Data;
    public Node next;

    public Node(int data)
    {
        Data = data;
        next = null;
    }
}

public class CustomLinkedList
{
    public Node head;
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }


    public static Node Merge(Node head1, Node head2)
    {
        if (head1 == null) return head2;
        if (head2 == null) return head1;

        if (head1.Data > head2.Data)
        {
            Node temp = head1;
            head1 = head2;
            head2 = temp;
        }

        Node result = head1; 
        Node prev = null;

        while (head1 != null && head2 != null)
        {
            if (head1.Data <= head2.Data)
            {
                prev = head1;
                head1 = head1.next;
            }
            else
            {
                Node next = head2.next;
                prev.next = head2;
                head2.next = head1;

                head2 = next;
                prev = prev.next;
            }
        }

        if (head2 != null)
        {
            prev.next = head2;
        }

        return result;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        CustomLinkedList l1 = new CustomLinkedList();
        l1.Add(1);
        l1.Add(3);
        l1.Add(5);

        CustomLinkedList l2 = new CustomLinkedList();
        l2.Add(2);
        l2.Add(4);
        l2.Add(6);

        Console.WriteLine("List 1: ");
        l1.Print();

        Console.WriteLine("List 2: ");
        l2.Print();

        Node NewHead = CustomLinkedList.Merge(l1.head, l2.head);
        Console.WriteLine("Merged List: ");
        Node temp = NewHead;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}
