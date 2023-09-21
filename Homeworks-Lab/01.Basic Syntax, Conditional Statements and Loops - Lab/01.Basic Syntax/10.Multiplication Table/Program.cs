using System;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{m} X {times} = {m * times}");
                times++;
            }
        }
    }
}