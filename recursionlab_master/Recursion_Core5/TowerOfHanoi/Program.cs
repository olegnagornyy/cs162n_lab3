using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter number of disks:");
            int n = int.Parse(Console.ReadLine());
            Disks(n, 1, 3, 2);
        }
        static void Disks(int n, int s, int f, int t)
        {
            if (n > 0)
            {
                Disks(n - 1, s, t, f);
                Console.WriteLine($"Move disk {n} from {s} to {f}");
                Disks(n - 1, t, f, s);
            }
        }
    }
}
