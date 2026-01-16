using System;

namespace traffic_manager
{
    class TrafficMenu
    {
        private TrafficUtility utility = new TrafficUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Vehicle Arrives");
                Console.WriteLine("2. Vehicle Exits");
                Console.WriteLine("3. Display State");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.VehicleArrives();
                        break;
                    case 2:
                        utility.VehicleExits();
                        break;
                    case 3:
                        utility.DisplayState();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
