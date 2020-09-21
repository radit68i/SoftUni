using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class _03_Rounding_Numbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] arr = input.Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int rounded = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{(decimal)arr[i]} => {rounded}"); // decimal ??????????????
            }
        }
    }
}
