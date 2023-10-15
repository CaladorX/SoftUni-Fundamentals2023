using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (type == "string")
            {
                string firstString = first;
                string secondString = second;
                string result = GetMax(firstString,secondString);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int a = int.Parse(first);
                int b = int.Parse(second);
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else
            {
                char a = char.Parse(first);
                char b = char.Parse(second);
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);

            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}