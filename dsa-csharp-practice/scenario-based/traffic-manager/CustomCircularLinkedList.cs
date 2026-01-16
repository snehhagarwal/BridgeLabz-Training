using System;

namespace traffic_manager
{
    class CustomCircularLinkedList
    {
        private CustomNode tail;

        public bool IsEmpty()
        {
            return tail == null;
        }

        public void Add(Vehicle vehicle)
        {
            CustomNode newNode = new CustomNode(vehicle);

            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public bool Remove(string number)
        {
            if (tail == null)
                return false;

            CustomNode curr = tail.Next;
            CustomNode prev = tail;

            do
            {
                if (curr.Data.Number == number)
                {
                    if (curr == tail && curr.Next == tail)
                        tail = null;
                    else
                    {
                        prev.Next = curr.Next;
                        if (curr == tail)
                            tail = prev;
                    }
                    return true;
                }

                prev = curr;
                curr = curr.Next;
            } while (curr != tail.Next);

            return false;
        }

        public void Display()
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout is empty");
                return;
            }

            CustomNode temp = tail.Next;
            do
            {
                Console.Write(temp.Data.Number + " -> ");
                temp = temp.Next;
            } while (temp != tail.Next);

            Console.WriteLine("Back to Start");
        }
    }
}
