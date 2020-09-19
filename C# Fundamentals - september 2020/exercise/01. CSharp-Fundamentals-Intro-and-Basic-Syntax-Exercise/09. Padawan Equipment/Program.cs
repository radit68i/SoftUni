using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceOfSabre = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double priceOfAllSasbres = Math.Ceiling(countStudents * 1.10) * priceOfSabre;
            double priceOfAllBelts = priceOfBelt * (countStudents - Math.Floor(countStudents / 6.0));  
            double priceOfAllRobes = priceOfRobe * countStudents;

            double totalPrice = priceOfAllSasbres + priceOfAllBelts + priceOfAllRobes;
            if (totalPrice <= allMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - allMoney:F2}lv more.");
            }
        }
    }
}
