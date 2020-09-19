using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string result = "";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int countDigit = input.Length;
                int mainDigit = input.ToCharArray()[0] - 48;
                int offcet = (mainDigit - 2) * 3;

                char letter = ' ';
                if (mainDigit != 0)
                {
                    if (mainDigit > 7)
                    {
                        offcet++;
                    }
                    letter = (char)(offcet + countDigit - 1 + 97);
                }
                result += letter;
            }
            Console.WriteLine(result);
        }
    }
}
