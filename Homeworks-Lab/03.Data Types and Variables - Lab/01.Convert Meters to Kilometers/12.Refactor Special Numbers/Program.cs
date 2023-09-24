using System;

namespace _12.Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1; num <= number; num++)
            {
                int sum = 0;
                int orderNumber = num;
                
                while (orderNumber > 0)
                {
                    sum += orderNumber % 10;
                    orderNumber /= 10;
                }

                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecialNum);
            }
        }
    }
}