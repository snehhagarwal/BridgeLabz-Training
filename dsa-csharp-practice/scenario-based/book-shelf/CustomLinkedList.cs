using System;

namespace CustomLinkedList
{
    public class CustomLinkedList
    {
        private Node? head;

        // Add at end
        public void AddLast(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Remove by value
        public bool Remove(string value)
        {
            if (head == null) return false;

            if (head.Data == value)
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Find value
        public string? Find(string value)
        {
            Node? temp = head;
            while (temp != null)
            {
                if (temp.Data == value)
                    return temp.Data;
                temp = temp.Next;
            }
            return null;
        }

        // Check existence
        public bool Exists(string value)
        {
            return Find(value) != null;
        }

        // Display list
        public void Display()
        {
            Node? temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}
