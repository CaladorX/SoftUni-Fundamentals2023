using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countofpeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalprice = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                totalprice = countofpeople * price;

                if (countofpeople >= 30)
                {
                    totalprice = totalprice * 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                totalprice = countofpeople * price;

                if (countofpeople >= 100)
                {
                    totalprice = (countofpeople - 10) * price;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }

                totalprice = countofpeople * price;

                if (countofpeople >= 10 &&  countofpeople <= 20)
                {
                    totalprice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalprice:F2}");
        }
    }
}