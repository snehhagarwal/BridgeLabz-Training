using System;

// Represents a node in the inventory linked list
class ItemNode
{
    public int Id,Qty;
    public string Name;
    public double Price;
    public ItemNode next;
}

// Manages the inventory using a linked list
class Inventory
{
    ItemNode head;

    // Adds a new item to the front of the list
    public void Add(int id,string name,int qty,double price)
    {
        ItemNode node=new ItemNode{Id=id,Name=name,Qty=qty,Price=price,next=head};
        head=node;
    }
    // Calculates and prints the total value of all items
    public void TotalValue()
    {
        double total=0;
        ItemNode temp=head;
        while (temp != null)
        {
            total+=temp.Price*temp.Qty;
            temp=temp.next;
        }
        Console.WriteLine("Total Inventory Value: " +total);
    }
}

// Main class to demonstrate the inventory system
class InventoryMain
{
    static void Main(string[] args)
    {
        Inventory inv=new Inventory();
        inv.Add(1,"Pencil",10,5);
        inv.Add(2,"Book",3,100);
        inv.TotalValue();
    }
}