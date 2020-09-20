using System;

namespace _05._Print_Part_of_the_ASCII_Table
{
    class _05_Print_Part_of_the_ASCII_Table
    {
        static void Main(string[] args)
        {
            char ch1 = (char)byte.Parse(Console.ReadLine());
            char ch2 = (char)byte.Parse(Console.ReadLine());

            for (char i = ch1; i <= ch2; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
