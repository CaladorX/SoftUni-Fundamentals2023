using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string GameName = Console.ReadLine();
            double cart = 0;

           while (GameName != "Game Time")
            {
                if (GameName == "OutFall 4")
                {                   
                    if (money >= 39.99)
                    {
                        money -= 39.99;
                        cart += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }                   
                }
                else if (GameName == "CS: OG")
                {                    
                    if (money >= 15.99)
                    {
                        money -= 15.99;
                        cart += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (GameName == "Zplinter Zell")
                {                    
                    if (money >= 19.99)
                    {
                        money -= 19.99;
                        cart += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (GameName == "Honored 2")
                {                    
                    if (money >= 59.99)
                    {
                        money -= 59.99;
                        cart += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (GameName == "RoverWatch")
                {                    
                    if (money >= 29.99)
                    {
                        money -= 29.99;
                        cart += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (GameName == "RoverWatch Origins Edition")
                {                   
                    if (money >= 39.99)
                    {
                        money -= 39.99;
                        cart += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                GameName = Console.ReadLine();

                if (money <= 0)
                {
                    break;
                }

            }

            if (money <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${cart:F2}. Remaining: ${money:F2}");
            }
        }
    }
}