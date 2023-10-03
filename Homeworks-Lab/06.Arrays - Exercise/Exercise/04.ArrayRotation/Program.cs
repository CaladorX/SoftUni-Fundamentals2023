namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int r = int.Parse(Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                var end = number[0];

                for (int j = 0; j < number.Length - 1; j++)
                {
                    number[j] = number[j + 1];
                }

                number[number.Length - 1] = end;
            }

            Console.WriteLine(string.Join(" ", number));

        }
    }
}