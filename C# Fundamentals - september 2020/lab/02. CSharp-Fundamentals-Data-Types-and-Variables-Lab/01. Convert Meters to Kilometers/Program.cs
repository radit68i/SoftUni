﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometer = meters / 1000m;
            Console.WriteLine("{0:F2}", kilometer);
        }
    }
}
