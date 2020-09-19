﻿using System;

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

            int head = 0;
            int mouse = 0;
            int key = 0;
            int disp = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalPrice += priceHeadSet;
                    head++;
                }
                if (i % 3 == 0)
                {
                    totalPrice += priceMouse;
                }
                if (i % 12 == 0)
                {
                    totalPrice += priceDisplay;
                }
                if (i % 6 == 0)
                {
                    totalPrice += priceKeyboard;
                }
            }

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}