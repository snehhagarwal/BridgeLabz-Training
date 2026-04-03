using System;

// Represents a node in the inventory linked list
class ItemNode
{
    public int Id, Qty;
    public string Name;
    public double Price;
    public ItemNode next;
}

// Manages the inventory using a linked list
class Inventory
{
    ItemNode head;

    // Adds a new item to the front of the list
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        ItemNode node = new ItemNode
        {
            Id = id,
            Name = name,
            Qty = qty,
            Price = price,
            next = head
        };
        head = node;
    }

    // Add at end
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        ItemNode node = new ItemNode
        {
            Id = id,
            Name = name,
            Qty = qty,
            Price = price,
            next = null
        };

        if (head == null)
        {
            head = node;
            return;
        }

        ItemNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = node;
    }

    // Add at specific position
    public void AddAtPosition(int pos, int id, string name, int qty, double price)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        ItemNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null) return;

        ItemNode node = new ItemNode
        {
            Id = id,
            Name = name,
            Qty = qty,
            Price = price,
            next = temp.next
        };

        temp.next = node;
    }

    // Remove item by ID
    public void RemoveById(int id)
    {
        if (head == null) return;

        if (head.Id == id)
        {
            head = head.next;
            return;
        }

        ItemNode temp = head;
        while (temp.next != null && temp.next.Id != id)
            temp = temp.next;

        if (temp.next != null)
            temp.next = temp.next.next;
    }

    // Update quantity by ID
    public void UpdateQuantity(int id, int qty)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.Id == id)
            {
                temp.Qty = qty;
                return;
            }
            temp = temp.next;
        }
    }

    // Search by ID
    public void SearchById(int id)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.Id == id)
            {
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Qty + " " + temp.Price);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found");
    }

    // Search by Name
    public void SearchByName(string name)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
            {
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Qty + " " + temp.Price);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Item not found");
    }

    // Display all items
    public void Display()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Qty + " " + temp.Price);
            temp = temp.next;
        }
    }


    // Calculates and prints the total value of all items
    public void TotalValue()
    {
        double total = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            total += temp.Price * temp.Qty;
            temp = temp.next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }

    // Sort by Name
    public void SortByName(bool ascending)
    {
        for (ItemNode i = head; i != null; i = i.next)
        {
            for (ItemNode j = i.next; j != null; j = j.next)
            {
                if ((ascending && i.Name.CompareTo(j.Name) > 0) ||
                    (!ascending && i.Name.CompareTo(j.Name) < 0))
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Sort by Price
    public void SortByPrice(bool ascending)
    {
        for (ItemNode i = head; i != null; i = i.next)
        {
            for (ItemNode j = i.next; j != null; j = j.next)
            {
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                {
                    Swap(i, j);
                }
            }
        }
    }

    private void Swap(ItemNode a, ItemNode b)
    {
        int id = a.Id;
        string name = a.Name;
        int qty = a.Qty;
        double price = a.Price;

        a.Id = b.Id;
        a.Name = b.Name;
        a.Qty = b.Qty;
        a.Price = b.Price;

        b.Id = id;
        b.Name = name;
        b.Qty = qty;
        b.Price = price;
    }
}

// Main class to demonstrate the inventory system
class InventoryMain
{
    static void Main(string[] args)
    {
        Inventory inv = new Inventory();

        // Add items
        inv.AddAtBeginning(1, "Pencil", 10, 5);
        inv.AddAtEnd(2, "Book", 3, 100);
        inv.AddAtEnd(3, "Eraser", 20, 2);

        // Add at specific position
        inv.AddAtPosition(2, 4, "Pen", 15, 10);

        Console.WriteLine("\nAll Items:");
        inv.Display();

        // Update quantity
        inv.UpdateQuantity(2, 5);

        Console.WriteLine("\nAfter Updating Quantity of Book:");
        inv.Display();

        // Search operations
        Console.WriteLine("\nSearch by ID:");
        inv.SearchById(3);

        Console.WriteLine("\nSearch by Name:");
        inv.SearchByName("Pen");

        // Total inventory value
        Console.WriteLine();
        inv.TotalValue();

        // Remove item
        inv.RemoveById(1);
        Console.WriteLine("\nAfter Removing Item ID 1:");
        inv.Display();

        // Sorting
        Console.WriteLine("\nSort by Name Ascending:");
        inv.SortByName(true);
        inv.Display();

        Console.WriteLine("\nSort by Price Descending:");
        inv.SortByPrice(false);
        inv.Display();
    }
}
