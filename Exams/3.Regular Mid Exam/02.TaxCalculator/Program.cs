using System;

namespace _02.TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vehicles = input.Split(">>");

            double totalTax = 0;

            foreach (string vehicle in vehicles)
            {
                string[] vehicleDetails = vehicle.Split(' ');
                string carType = vehicleDetails[0];
                int years = int.Parse(vehicleDetails[1]);
                int kilometers = int.Parse(vehicleDetails[2]);

                double tax = 0;

                if (carType == "family")
                {
                    tax = 50 - 5 * years;
                    if (kilometers > 3000)
                    {
                        int exceedingKilometers = kilometers - 3000;
                        tax += exceedingKilometers / 3000 * 12;
                    }
                }
                else if (carType == "heavyDuty")
                {
                    tax = 80 - 8 * years;
                    if (kilometers > 9000)
                    {
                        int exceedingKilometers = kilometers - 9000;
                        tax += exceedingKilometers / 9000 * 14;
                    }
                }
                else if (carType == "sports")
                {
                    tax = 100 - 9 * years;
                    if (kilometers > 2000)
                    {
                        int exceedingKilometers = kilometers - 2000;
                        tax += exceedingKilometers / 2000 * 18;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                    continue; // Skip to the next iteration
                }

                totalTax += tax;
                Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");
        }
    }
}