namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[Numbers.Length - 1];

            if (Numbers.Length == 1)
            {
                Console.WriteLine(Numbers[0]);
                return;
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = Numbers[j] + Numbers[j + 1];
                }
                Numbers = condensed;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}