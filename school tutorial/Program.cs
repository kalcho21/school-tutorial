﻿namespace school_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int n = 0;
            Print(n);
        }
        static void Print(int n)
        {
            Console.WriteLine($"{n++} {Console.ReadLine()}"); 
        }
    }
}
