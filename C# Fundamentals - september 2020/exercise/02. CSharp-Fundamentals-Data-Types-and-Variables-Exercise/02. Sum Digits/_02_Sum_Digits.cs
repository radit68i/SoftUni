using System;

namespace _02._Sum_Digits
{
    class _02_Sum_Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            byte sumOfDigits = 0;
            while(num != 0)
            {
                byte digit = (byte)(num % 10);
                num /= 10;
                sumOfDigits += digit;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
