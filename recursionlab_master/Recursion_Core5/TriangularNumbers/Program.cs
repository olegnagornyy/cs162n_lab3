using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 triangular numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"triangular {i} = {TriangularNumber(i)}");
            } 
        }
        static int TriangularNumber(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + TriangularNumber(n - 1);
        }
    }
}
