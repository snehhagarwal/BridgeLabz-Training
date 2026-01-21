using System;
using System.Collections.Generic;

public class CheckoutQueue
{
    // Queue for customers (FIFO)
    private Queue<Customer> queue = new Queue<Customer>();

    // Store reference
    private ItemStore store;

    // Constructor
    public CheckoutQueue(ItemStore store)
    {
        this.store = store;
    }  

    // Add customer to queue
    public void AddCustomer()
    {
        Console.Write("Enter Customer Name: ");
        Customer customer = new Customer(Console.ReadLine());

        Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());

        // Add items to cart
        for (int i = 0; i < n; i++)
        {
            Console.Write("Item Name: ");
            string item = Console.ReadLine();

            // Validate item
            if (!store.ItemExists(item))
            {
                Console.WriteLine("Item not found!");
                i--;
                continue;
            }

            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            // Add item to cart
            customer.AddItem(item, qty);
        }

        // Enqueue customer
        queue.Enqueue(customer);
        Console.WriteLine("Customer added.\n");
    }

    // Process billing
    public void ProcessBilling()
    {
        // Check empty queue
        if (queue.Count == 0)
        {
            Console.WriteLine("No customers.\n");
            return;
        }

        // Dequeue customer
        Customer customer = queue.Dequeue();
        int total = 0;

        Console.WriteLine($"\n--- Billing for {customer.Name} ---");

        // Calculate bill
        foreach (var item in customer.Cart)
        {
            if (store.IsAvailable(item.Key, item.Value))
            {
                int cost = store.GetPrice(item.Key) * item.Value;
                total += cost;
                store.UpdateStock(item.Key, item.Value);

                Console.WriteLine($"{item.Key} x {item.Value} = {cost}");
            }
            else
            {
                Console.WriteLine($"{item.Key} - Insufficient stock");
            }
        }

        // Print total
        Console.WriteLine($"Total Amount: {total}\n");
    }
}
