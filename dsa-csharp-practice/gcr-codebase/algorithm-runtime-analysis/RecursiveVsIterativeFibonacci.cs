using System;
using System.Diagnostics;

// Compare Recursive vs Iterative Fibonacci performance 
class RecursiveVsIterativeFibonacci{
    public static void Main(string[] args){ 
        int n = 30;
        Stopwatch sw = new Stopwatch();

        // Recursive Fibonacci
        sw.Start();
        FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Time: " + sw.ElapsedMilliseconds + " ms");

        // Iterative Fibonacci
        sw.Restart();
        FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Recursive Fibonacci Method to find nth term
    static int FibonacciRecursive(int n){
        if (n <= 1) return n;                                              // Base case
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);      // Recursive call
    }

    // Iterative Fibonacci Method to find nth term
    static int FibonacciIterative(int n){
        int a = 0, b = 1;                        // First two Fibonacci numbers
        for (int i = 2; i <= n; i++){           // Loop from 2 to n
            int sum = a + b;                    // Calculate next Fibonacci number
            a = b;                              // Update a to previous b
            b = sum;                            // Update b to new sum
        }
        return b;
    }
}
