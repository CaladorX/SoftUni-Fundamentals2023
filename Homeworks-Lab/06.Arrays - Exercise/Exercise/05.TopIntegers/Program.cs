using System;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < number.Length; i++)
            {
                bool isTrue = true;
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] <= number[j]) 
                    {
                        isTrue = false;
                    }
                }

                if(isTrue)
                {
                    Console.Write(number[i] + " ");
                }
            }        
        }
    }
}