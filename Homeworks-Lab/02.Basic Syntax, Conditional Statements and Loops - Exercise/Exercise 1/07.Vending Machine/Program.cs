﻿using System;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double money = 0;

            while (inputCoins != "Start")
            {
                double amountofCoin = double.Parse(inputCoins);

                if (amountofCoin == 0.1)
                {
                    money += 0.1;
                }
                else if (amountofCoin == 0.2)
                {
                    money += 0.2;
                }
                else if (amountofCoin == 0.5)
                {
                    money += 0.5;
                }
                else if (amountofCoin == 1)
                {
                    money += 1;
                }
                else if (amountofCoin == 2)
                {
                    money += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {amountofCoin}");
                }

                inputCoins = Console.ReadLine();

            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (money >= 2) 
                    {
                        money -= 2;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        money -= 0.7;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        money -= 1.5;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        money -= 0.8;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= 1)
                    {
                        money -= 1;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
        }
    }
}