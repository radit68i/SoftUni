using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadSet = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            totalPrice += lostGames / 2 * priceHeadSet;
            totalPrice += lostGames / 3 * priceMouse;
            totalPrice += lostGames / 6 * priceKeyboard;
            totalPrice += lostGames / 12 * priceDisplay;

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
