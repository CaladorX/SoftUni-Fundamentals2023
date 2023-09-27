namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            decimal biggestKegtotal = 0;
            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                decimal height = decimal.Parse(Console.ReadLine());

                decimal total = (decimal)Math.PI * (radius * radius) * height;

                if (total > biggestKegtotal)
                {
                    biggestKegtotal = total;
                    biggestKeg = model;
                }   
            }

            Console.WriteLine(biggestKeg);
        }
    }
}