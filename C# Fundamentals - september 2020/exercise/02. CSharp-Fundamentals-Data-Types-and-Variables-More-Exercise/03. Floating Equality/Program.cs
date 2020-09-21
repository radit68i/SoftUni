using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001; // precision

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double diff = Math.Abs(a - b);
            bool isEqual = true;
            if (diff > eps)
            {
                isEqual = false;
            }
            Console.WriteLine(isEqual);
        }
    }
}
