namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                double numbers = number[i];
                double roundNumber = Math.Round(numbers, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{Convert.ToDecimal(numbers)} => {Convert.ToDecimal(roundNumber)}");
            }
        }
    }
}