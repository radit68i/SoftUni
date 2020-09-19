using System;
using System.Runtime.InteropServices.ComTypes;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());

            double totalSpent = 0;
            string input = Console.ReadLine();
            while (input != "Game Time")
            {
                double price = 0;
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                }

                string resultToPrint = "";
                if (price != 0)
                {
                    allMoney -= price;
                    if (allMoney >= 0)
                    {
                        resultToPrint = $"Bought {input}";
                        totalSpent += price;
                    }
                    else
                    {
                        allMoney += price;
                        resultToPrint = "Too Expensive";
                    }
                }
                else
                {
                    resultToPrint = "Not Found";
                }

                Console.WriteLine(resultToPrint);
                if (allMoney == 0)
                {
                    break;
                }
               

                input = Console.ReadLine();
            }

            if (allMoney == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${allMoney:F2}");
            }
            

        }
    }
}
