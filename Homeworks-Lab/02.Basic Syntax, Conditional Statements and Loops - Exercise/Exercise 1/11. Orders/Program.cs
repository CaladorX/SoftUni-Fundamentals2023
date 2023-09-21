namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double price = 0;

            for (int i = 0; i < n; i++)
            {

                double totalprice = 0;

                double PricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int CapsuleCount = int.Parse(Console.ReadLine());

                totalprice = (days * CapsuleCount) * PricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${totalprice:F2}");

                price += totalprice;
            }

            Console.WriteLine($"Total: ${price:F2}");
        }
    }
}