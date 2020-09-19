using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool isSpecialNum = false;
                int num  = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
            }
        }
    }
}
