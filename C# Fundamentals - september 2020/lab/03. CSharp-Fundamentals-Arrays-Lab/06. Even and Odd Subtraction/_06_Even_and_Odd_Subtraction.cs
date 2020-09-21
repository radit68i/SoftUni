using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class _06_Even_and_Odd_Subtraction
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = arr.Where(x => x % 2 == 0).Sum();
            int sumOdd = arr.Where(x => x % 2 != 0).Sum();
            Console.WriteLine($"{sumEven - sumOdd}");
        }
    }
}
