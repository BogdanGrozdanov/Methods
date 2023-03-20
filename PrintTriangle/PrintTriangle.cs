﻿namespace PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(10);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = 0; i < end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1,i-1);
            }
        }

    }
}