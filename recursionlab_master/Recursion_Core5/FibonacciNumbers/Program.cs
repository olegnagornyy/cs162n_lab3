using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 Fibonacci numbers:");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Fibonacci {i} = {FibonacciNumber(i)}");
            }
        }
        static int FibonacciNumber(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }
    }
}
