namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int smallest = FindNumber(first, second, third);
            Console.WriteLine(smallest);

        }

        private static int FindNumber(int first, int second, int third)
        {
            if (first <= second && first <= third)
            {
                return first;
            }
            else if (second <= first && second <= third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}