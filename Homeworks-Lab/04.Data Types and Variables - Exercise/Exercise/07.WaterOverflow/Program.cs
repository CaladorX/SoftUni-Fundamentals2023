namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int TotalLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters + TotalLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    TotalLiters += liters;
                }        
            }
            Console.WriteLine($"{TotalLiters}");
        }
    }
}