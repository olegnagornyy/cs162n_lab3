using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Reverse string using stack
        Console.Write("enter string to reverse: ");
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            stack.Push(ch);
        }

        Console.Write("reversed string: ");
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
        Console.WriteLine();

        //Generate binary numbers using queue
        Console.Write("\nEnter positive integer: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        Console.WriteLine("Binary numbers from 1 to " + n + ":");
        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            Console.WriteLine(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}