using System;

namespace _04._Sum_of_Chars
{
    class _04_Sum_of_Chars
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            ushort sum = 0;
            for (byte i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
