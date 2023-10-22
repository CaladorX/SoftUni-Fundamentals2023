namespace _02.TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>");
            double TotalTax = 0;

            while (vehicles.Length > 0)
            {
                string[] currentCar = vehicles[0].Split(' ');
                string carType = currentCar[0];
                int years = int.Parse(currentCar[1]);
                int kilometers = int.Parse(currentCar[2]);
                double tax = 0;

                if (carType == "family")
                {
                    tax = 50;
                    for (int year = 1; year <= years; year++)
                    {
                        tax -= 5;
                    }

                    while (kilometers - 3000 >= 0)
                    {
                        tax += 12;
                        kilometers -= 3000;
                    }

                    TotalTax += tax;
                    Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
                }
                else if (carType == "heavyDuty")
                {
                    tax = 80;
                    for (int year = 1; year <= years; year++)
                    {
                        tax -= 8;
                    }

                    while (kilometers - 9000 >= 0)
                    {
                        tax += 14;
                        kilometers -= 9000;
                    }

                    TotalTax += tax;
                    Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
                }
                else if (carType == "sports")
                {
                    tax = 100;
                    for (int year = 1; year <= years; year++)
                    {
                        tax -= 9;
                    }

                    while (kilometers - 2000 >= 0)
                    {
                        tax += 18;
                        kilometers -= 2000;
                    }

                    TotalTax += tax;
                    Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }

                vehicles = vehicles[1..];
            }

            Console.WriteLine($"The National Revenue Agency will collect {TotalTax:F2} euros in taxes.");
        }
    }
}