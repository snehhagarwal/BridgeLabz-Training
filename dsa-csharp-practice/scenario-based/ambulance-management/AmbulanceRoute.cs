using System;

class AmbulanceRoute
{
    private AmbulanceNode head;

    // Add hospital unit to circular linked list
    public void AddHospitalUnit(string name, bool available)
    {
        AmbulanceNode newNode = new AmbulanceNode(name, available);

        if (head == null)
        {
            head = newNode;
            newNode.next = head;
        }
        else
        {
            AmbulanceNode temp = head;

            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = newNode;
            newNode.next = head;
        }
    }

    // Find nearest available unit
    public void FindNearestAvailableUnit()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units present.");
            return;
        }

        AmbulanceNode temp = head;

        do
        {
            Console.WriteLine("Checking unit: " + temp.unitName);

            if (temp.isAvailable)
            {
                Console.WriteLine("Patient redirected to: " + temp.unitName);
                return;
            }

            temp = temp.next;

        } while (temp != head);

        Console.WriteLine("No unit available for emergency treatment.");
    }

    // Remove unit under maintenance
    public void RemoveHospitalUnit(string name)
    {
        if (head == null)
            return;

        AmbulanceNode current = head;
        AmbulanceNode previous = null;

        do
        {
            if (current.unitName == name)
            {
                if (previous != null)
                {
                    previous.next = current.next;
                }
                else
                {
                    AmbulanceNode last = head;
                    while (last.next != head)
                    {
                        last = last.next;
                    }

                    head = head.next;
                    last.next = head;
                }

                Console.WriteLine(name + " removed (Under Maintenance)");
                return;
            }

            previous = current;
            current = current.next;

        } while (current != head);
    }

    // Display all hospital units
    public void DisplayUnits()
    {
        if (head == null)
            return;

        AmbulanceNode temp = head;

        Console.WriteLine("\nHospital Units:");
        do
        {
            Console.WriteLine(temp.unitName + " | Available: " + temp.isAvailable);
            temp = temp.next;
        } while (temp != head);
    }
}
