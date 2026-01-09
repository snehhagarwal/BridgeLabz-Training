using System;
using System.Collections.Generic;

// Calculates stock span using stack
class StockSpan
{
    // Computes span for each day
    static void CalculateSpan(int[] prices)
    {
        // Stack for indices, Span array
        Stack<int> stack=new Stack<int>();
        int[] span=new int[prices.Length];

        for(int i = 0; i < prices.Length; i++)
        {
            // Pop smaller or equal prices
            while(stack.Count>0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // Calculate span value
            if (stack.Count == 0)
            {
                span[i]=i+1;
            }
            else
            {
                span[i]=i-stack.Peek();
            }

            // Push current index
            stack.Push(i);
        }

        // Print span values
        for(int i = 0; i < span.Length; i++)
        {
            Console.Write(span[i] + " ");
        }
    }

    // Main method for input
    static void Main(string[] args)
    {
        Console.Write("Enter number of days: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] prices=new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter price: ");
            prices[i]=Convert.ToInt32(Console.ReadLine());
        }

        CalculateSpan(prices);
    }
}