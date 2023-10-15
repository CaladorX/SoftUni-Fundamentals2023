namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            Vend(product, quantity);
        }

        static void Vend(string product, int quantity)
        {
            double price = 0;
            double total = 0;

            if (product == "coffee")
            {
                price = 1.50;
                total = price * quantity;
            }
            else if (product == "water")
            {
                price = 1.00;
                total = price * quantity;
            }
            else if (product == "coke")
            {
                price = 1.40;
                total = price * quantity;
            }
            else
            {
                price = 2.00;
                total = price * quantity;
            }

            Console.WriteLine($"{total:f2}");

        }
    }
}