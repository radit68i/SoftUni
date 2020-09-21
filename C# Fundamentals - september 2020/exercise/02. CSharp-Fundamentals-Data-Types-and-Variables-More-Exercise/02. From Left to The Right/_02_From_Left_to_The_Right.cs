using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class _02_From_Left_to_The_Right
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] arrNums = input.Split(" ");
                long leftNum = long.Parse(arrNums[0]);
                long rightNum = long.Parse(arrNums[1]);

                int sumDigits = 0;
                if (leftNum > rightNum)
                {
                    if (leftNum < 0)
                    {
                        arrNums[0] = arrNums[0].TrimStart('-');
                    }
                    sumDigits = arrNums[0].ToCharArray().Select(x => x - 48).ToArray().Sum();
                }
                else
                {
                    if (rightNum < 0)
                    {
                        arrNums[1] = arrNums[0].TrimStart('-');
                    }
                    sumDigits = arrNums[1].ToCharArray().Select(x => x - 48).ToArray().Sum();
                }

                Console.WriteLine(sumDigits);
            }
        }
    }
}
