using System;

namespace _12.Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            while (true)
            {
                int a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(a)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }                            
            }            
        }
    }
}