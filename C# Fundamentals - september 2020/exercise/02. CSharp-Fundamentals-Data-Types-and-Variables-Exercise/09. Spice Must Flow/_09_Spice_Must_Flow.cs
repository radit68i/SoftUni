using System;

namespace _09._Spice_Must_Flow
{
    class _09_Spice_Must_Flow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalYield = 0;
            ushort dayCouner = 0;
            while (startingYield >= 100)
            {
                totalYield += startingYield - 26;
                startingYield -= 10;
                dayCouner++;
            }
            totalYield -= 26;
            if (totalYield < 0)
            {
                totalYield = 0;
            }
            Console.WriteLine(dayCouner);
            Console.WriteLine(totalYield);
        }
    }
}
