using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sumCoins = 0;
            while (input != "Start")
            {
                double currCoin = double.Parse(input);
                if ((currCoin == 0.1) || (currCoin == 0.2) || (currCoin == 0.5) || (currCoin == 1.0) || (currCoin == 2.0))
                {
                    sumCoins += currCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                double price = 0;
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                }

                if (price != 0)
                {
                    sumCoins -= price;
                    if (sumCoins >= 0)
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        sumCoins += price;
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
               
                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCoins:F2}");
        }
    }
}
