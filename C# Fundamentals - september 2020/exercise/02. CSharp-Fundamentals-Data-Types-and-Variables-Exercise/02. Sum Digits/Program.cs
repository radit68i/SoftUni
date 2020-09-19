using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            while(num != 0)
            {
                int digit = num % 10;
                num /= 10;
                sumOfDigits += digit;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
