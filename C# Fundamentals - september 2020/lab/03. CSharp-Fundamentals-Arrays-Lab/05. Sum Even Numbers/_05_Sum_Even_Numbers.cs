using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class _05_Sum_Even_Numbers
    {
        static void Main(string[] args)
        {
            int sumEven = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).Sum();
            Console.WriteLine(sumEven);
        }
    }
}
