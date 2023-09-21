using System;

namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headsetprice = double.Parse(Console.ReadLine());
            double mouseprice = double.Parse(Console.ReadLine());
            double keyboardprice = double.Parse(Console.ReadLine());
            double displayprice = double.Parse(Console.ReadLine());

            double money = headsetprice * (lostgames / 2);
            money += mouseprice * (lostgames / 3);
            money += keyboardprice * (lostgames / 6);
            money += displayprice * (lostgames / 12);

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}