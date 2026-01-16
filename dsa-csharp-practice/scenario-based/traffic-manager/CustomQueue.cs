using System;

namespace traffic_manager
{
    class CustomQueue
    {
        private Vehicle[] queue;
        private int front, rear, size, capacity;

        public CustomQueue(int capacity)
        {
            this.capacity = capacity;
            queue = new Vehicle[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool Enqueue(Vehicle vehicle)
        {
            if (size == capacity)
            {
                Console.WriteLine("Queue Overflow: Waiting area full");
                return false;
            }

            rear = (rear + 1) % capacity;
            queue[rear] = vehicle;
            size++;
            return true;
        }

        public Vehicle Dequeue()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue Underflow: No vehicles waiting");
                return null;
            }

            Vehicle vehicle = queue[front];
            front = (front + 1) % capacity;
            size--;
            return vehicle;
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Waiting queue empty");
                return;
            }

            Console.Write("Queue: ");
            for (int i = 0; i < size; i++)
            {
                int index = (front + i) % capacity;
                Console.Write(queue[index].Number + " <- ");
            }
            Console.WriteLine("Rear");
        }
    }
}
