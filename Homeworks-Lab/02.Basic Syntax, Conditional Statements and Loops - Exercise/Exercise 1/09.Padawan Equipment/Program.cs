using System;

namespace _09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountofmoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceofLighsaber = double.Parse(Console.ReadLine());
            double priceofRobe = double.Parse(Console.ReadLine());
            double priceofBelt = double.Parse(Console.ReadLine());

            double priceForAllLightsaber = Math.Ceiling(students * 1.1) * priceofLighsaber;
            double priceForAllRobe = students * priceofRobe;

            int FreeBelts = students / 6;

            double priceForAllBelt = (students - FreeBelts) * priceofBelt;
            
            double FinalPrice = priceForAllLightsaber + priceForAllBelt + priceForAllRobe;

            if (FinalPrice <= amountofmoney)
            {
                Console.WriteLine($"The money is enough - it would cost {FinalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = FinalPrice - amountofmoney;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }

        }
    }
}