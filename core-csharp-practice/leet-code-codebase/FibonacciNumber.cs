using System;

class FibonacciNumber {
    // Method to calculate nth Fibonacci number
    public int GetFibonacci(int n) {
        if (n <= 1) {
            return n;
        }
        int a = 0;
        int b = 1;
        for (int i = 2; i <= n; i++) {
            int c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    // Main method for demonstration
    static void Main(string[] args) {
        FibonacciNumber fib = new FibonacciNumber();
        Console.WriteLine("Enter n for nth Fibonacci number:");
        int n = int.Parse(Console.ReadLine());
        int result = fib.GetFibonacci(n);
        Console.WriteLine($"Fibonacci number at position {n} is {result}");
    }
}