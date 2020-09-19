using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string townPopulation = Console.ReadLine();
            string townArea = Console.ReadLine();

            Console.WriteLine($"Town {townName} has population of {townPopulation} and area {townArea} square km.");
        }
    }
}
