using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];

            for (int i = 0; i < 3; i++)
            {
                if (double.TryParse(Console.ReadLine(), out double n))
                {
                    numbers[i] = n;
                }
                else
                {
                    i--;
                }
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}