﻿namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(first) / Factorial(second)):f2}");
        }

        private static double Factorial(int number)
        {
            double firstfact = 1;
            for (int i = 1; i <= number; i++)
            {
                firstfact *= i;
            }
            return firstfact;
        }
    }
}