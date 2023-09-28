using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            int[] roundNumber = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                roundNumber[i] = (int)Math.Round(number[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{number[i]} => {roundNumber[i]}");
            }
        }
    }
}