using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool isSpesial = false;
                int num = i;
                while (num != 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    sum += digit;
                }

                switch (sum)
                {
                    case 5:
                    case 7:
                    case 11:
                        isSpesial = true;
                        break;
                }
                Console.WriteLine($"{i} -> {isSpesial}");
            }
        }
    }
}
