using System;
using System.Collections.Generic;

// Sorts a stack using recursion
class SortStackRecursion
{
    // Inserts value into sorted stack
    static void Insert(Stack<int> stack,int value)
    {
        if(stack.Count==0 || value > stack.Peek())
        {
            stack.Push(value);
            return;
        }

        int temp=stack.Pop();
        Insert(stack,value);
        stack.Push(temp);
    }

    // Recursively sorts the stack
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp=stack.Pop();
            SortStack(stack);
            Insert(stack,temp);
        }
    }

    // Displays stack elements
    static void Display(Stack<int> stack)
    {
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }

    // Main method to input and sort stack
    static void Main(string[] args)
    {
        Stack<int> stack=new Stack<int>();

        Console.Write("Enter number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter value: ");
            stack.Push(Convert.ToInt32(Console.ReadLine()));
        }

        SortStack(stack);
        Display(stack);
    }
}