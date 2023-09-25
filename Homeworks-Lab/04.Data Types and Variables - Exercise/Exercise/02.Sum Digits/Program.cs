using System;

namespace _02.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
            }

            Console.WriteLine(sum);
        }
    }
}