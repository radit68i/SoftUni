using System;

namespace _04._Refactoring___Prime_Checker
{
    class _04_Refactoring___Prime_Checker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string result = $"{i} -> {isPrime}";
                Console.WriteLine(result.ToLower());
            }
        }
    }
}
