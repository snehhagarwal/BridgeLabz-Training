using System;

namespace traffic_manager
{
    class TrafficUtility : ITraffic
    {
        private CustomCircularLinkedList roundabout;
        private CustomQueue queue;

        public TrafficUtility()
        {
            roundabout = new CustomCircularLinkedList();
            queue = new CustomQueue(10);
        }

        public void VehicleArrives()
        {
            Console.Write("Enter vehicle number: ");
            string number = Console.ReadLine();

            if (roundabout.IsEmpty())
            {
                roundabout.Add(new Vehicle(number));
                Console.WriteLine("Vehicle entered roundabout");
            }
            else
            {
                queue.Enqueue(new Vehicle(number));
            }
        }

        public void VehicleExits()
        {
            Console.Write("Enter exiting vehicle number: ");
            string number = Console.ReadLine();

            if (roundabout.Remove(number))
            {
                Console.WriteLine("Vehicle exited roundabout");

                Vehicle next = queue.Dequeue();
                if (next != null)
                {
                    roundabout.Add(next);
                    Console.WriteLine("Waiting vehicle entered roundabout");
                }
            }
            else
            {
                Console.WriteLine("Vehicle not found");
            }
        }

        public void DisplayState()
        {
            Console.WriteLine("\nRoundabout:");
            roundabout.Display();

            Console.WriteLine("\nWaiting Queue:");
            queue.Display();
        }
    }
}
