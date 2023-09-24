using System;

namespace _10.Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            for (int i = 0; i < letter.Length; i++)
            {
                if (Char.IsLower(letter[i]))
                {
                    Console.Write("lower-case");
                }
                else
                {
                    Console.WriteLine("upper-case");
                }
            }          
        }
    }
}