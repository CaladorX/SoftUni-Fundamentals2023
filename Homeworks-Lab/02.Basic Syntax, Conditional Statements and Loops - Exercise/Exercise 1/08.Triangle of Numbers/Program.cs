using System;

namespace _08.Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rol = 1; rol <= n; rol++)
            {
                for (int col = 1; col <= rol; col++)
                {
                    Console.Write($"{rol} ");
                }
                Console.WriteLine();
            }
        }
    }
}