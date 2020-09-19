using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int temp = 0;
            if (num2 > num1)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num3 > num2)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num2 > num1)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
